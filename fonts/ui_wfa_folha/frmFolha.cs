using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using cl_dal;
using cl_models;

namespace ui_wfa_folha
{
    public partial class frmFolha : Form
    {
        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataReader _leitor;
        private SqlDataAdapter _adptador;
        private DataTable _tabela;

        public frmFolha()
        {
            InitializeComponent();
        }

        clsFolhaDal folhaDal = new clsFolhaDal();
        clsFolhaModel folhaModel = new clsFolhaModel();

        private void frmFolha_Load(object sender, EventArgs e)
        {
            AtivarFormulario();

            clsFuncionariosDal funcionariosDal = new clsFuncionariosDal();

            cmbFuncionario.DataSource = funcionariosDal.ListarTodos();
            cmbFuncionario.DisplayMember = "nome";
            cmbFuncionario.ValueMember = "id_funcionario";
            cmbFuncionario.SelectedIndex = -1;

            tbSalarioBruto.TextChanged += tbSalarioBruto_TextChanged;
        }

        public void LimparCampos()
        {
            tbPercentualINSS.Text = "";
            tbSalarioBruto.Text = "";
            tbSalarioLiquido.Text = "";
            tbFgts.Text = "";
            mtbMesAno.Text = "";
            cmbFuncionario.Text = "";
            tbSalario13.Text = "";
            tbHorasExtras.Text = "";
        }

        private void AtivarFormulario()
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnPesquisar.Enabled = true;
            btnExcluir.Enabled = false;

            tbSalarioBruto.Enabled = false;
            tbHorasExtras.Enabled = false;
            mtbMesAno.Enabled = false;
            cmbFuncionario.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;

            LimparCampos();
            mtbMesAno.Focus();

            tbSalarioBruto.Enabled = true;
            tbHorasExtras.Enabled = true;
            mtbMesAno.Enabled = true;
            cmbFuncionario.Enabled = true;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;

            tbSalarioBruto.Enabled = true;
            tbHorasExtras.Enabled = true;
            mtbMesAno.Enabled = true;
            cmbFuncionario.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = true;

            LimparCampos();

            tbSalarioBruto.Enabled = false;
            tbHorasExtras.Enabled = false;
            mtbMesAno.Enabled = false;
            cmbFuncionario.Enabled = false;
            tbSalario13.Enabled = false;
            tbSalario13.BackColor = SystemColors.InactiveCaption;
        }
        private decimal CalcularPercentualINSS(decimal salario)
        {

            if (salario > 0 && salario <= 1045)
            {
                return 7.5m;
            }
            else if (salario > 1045 && salario <= 2089.6m)
            {
                return 9m;
            }
            else if (salario > 2089.6m && salario <= 3134.4m)
            {
                return 12m;
            }
            else if (salario == 0)
            {
                return 0;
            }
            else
            {
                return 14m;
            }
        }

        private decimal CalcularDescontoINSS(decimal salarioBruto, decimal percentualINSS)
        {
            return salarioBruto * (percentualINSS / 100m);
        }

        private decimal CalcularValorFGTS(decimal salario, decimal percentualFGTS)
        {
            return salario * (percentualFGTS / 100m);
        }
        private decimal CalcularValorHorasExtras(decimal salarioBruto, decimal horasExtras)
        {
            // Por exemplo, assumindo que o valor das horas extras seja 100% do salário bruto por hora extra
            decimal valorPorHoraExtra = (salarioBruto / 220) * 1.0m; // 100%
            return valorPorHoraExtra * horasExtras;
        }
        private decimal CalcularSalario13(decimal salarioBruto)
        {
            // Assume que o 13º salário é 1/12 do salário bruto para cada mês trabalhado
            decimal salario13 = (salarioBruto / 12) * 11; // assumindo que vc trabalha 11 meses no ano
            return salario13;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;

            _conexao = clsConnection.obterConexao();

            string consulta = "select mes_ano, id_funcionario from folha where mes_ano = @mes_ano";
            _comandos = new SqlCommand(consulta, _conexao);
            _comandos.Connection = _conexao;
            _comandos.CommandText = consulta;
            _comandos.Parameters.AddWithValue("@mes_ano", mtbMesAno.Text);

            SqlDataReader _leitor = _comandos.ExecuteReader();

            bool folhaExistente = false;

            while (_leitor.Read())
            {
                int idFuncionarioExistente = Convert.ToInt32(_leitor["id_funcionario"]);

                if (idFuncionarioExistente == (int)cmbFuncionario.SelectedValue)
                {
                    folhaExistente = true;
                    break;
                }
            }
            _leitor.Close();

            // Verifica se a situação do funcionário é igual a 1 (ativo)
            string consultaSituacao = "select situacao from funcionarios where id_funcionario = @id_funcionario";
            _comandos = new SqlCommand(consultaSituacao, _conexao);
            _comandos.Parameters.AddWithValue("@id_funcionario", (int)cmbFuncionario.SelectedValue);

            object situacaoObj = _comandos.ExecuteScalar();
            bool situacaoAtiva = situacaoObj != null && situacaoObj != DBNull.Value && Convert.ToInt32(situacaoObj) == 1;

            // Verifica se o mês/ano da folha não é anterior à data de admissão do funcionário
            string consultaAdmissao = "select data_admissao from funcionarios where id_funcionario = @id_funcionario";
            _comandos = new SqlCommand(consultaAdmissao, _conexao);
            _comandos.Parameters.AddWithValue("@id_funcionario", (int)cmbFuncionario.SelectedValue);

            object dataAdmissaoObj = _comandos.ExecuteScalar();

            if (dataAdmissaoObj != null && dataAdmissaoObj != DBNull.Value)
            {
                DateTime dataAdmissao = Convert.ToDateTime(dataAdmissaoObj);

                if (dataAdmissao > DateTime.Parse("01/" + mtbMesAno.Text))
                {
                    MessageBox.Show("O mês/ano da folha não pode ser anterior à data de admissão do funcionário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimparCampos();
                    return;
                }
            }
            if (folhaExistente)
            {
                DialogResult result = MessageBox.Show("Folha já lançada para o período informado para este funcionário. Deseja editar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (situacaoAtiva)
                    { 
                        folhaModel.Mes_ano = mtbMesAno.Text;
                        folhaModel.Id_funcionario = (int)cmbFuncionario.SelectedValue;
                        folhaModel.Salario = decimal.Parse(tbSalarioBruto.Text);
                        folhaModel.Percentual_inss = float.Parse(tbPercentualINSS.Text);
                        folhaModel.Fgts = float.Parse(tbFgts.Text);
                        folhaModel.Salario_liquido = decimal.Parse(tbSalarioLiquido.Text);

                        if (tbHorasExtras.Text.Length > 0)
                        {
                            folhaModel.Salario_hora_extra = decimal.Parse(tbSalarioLiquido.Text);
                        }

                        folhaModel.Hora_extra = int.TryParse(tbHorasExtras.Text, out int horasExtras) && horasExtras > 0 ? horasExtras : 0;

                        folhaModel.Salario_13 = decimal.TryParse(tbSalario13.Text, out decimal salario13) && salario13 > 0 ? salario13 : 0m;

                        folhaDal.Atualizar(folhaModel);

                        MessageBox.Show("Dados da Folha Atualizados com Sucesso!", "Aviso");

                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Não é possível editar a folha. O funcionário não está ativo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimparCampos();
                    }
                }
            }
            else
            {
                if (situacaoAtiva)
                {
                    folhaModel.Mes_ano = mtbMesAno.Text;
                    folhaModel.Id_funcionario = (int)cmbFuncionario.SelectedValue;
                    folhaModel.Salario = decimal.Parse(tbSalarioBruto.Text);
                    folhaModel.Percentual_inss = float.Parse(tbPercentualINSS.Text);
                    folhaModel.Fgts = float.Parse(tbFgts.Text);
                    folhaModel.Salario_liquido = decimal.Parse(tbSalarioLiquido.Text);

                    if (tbHorasExtras.Text.Length > 0)
                    {
                        folhaModel.Salario_hora_extra = decimal.Parse(tbSalarioLiquido.Text);
                    }

                    folhaModel.Hora_extra = int.TryParse(tbHorasExtras.Text, out int horasExtras) && horasExtras > 0 ? horasExtras : 0;

                    folhaModel.Salario_13 = decimal.TryParse(tbSalario13.Text, out decimal salario13) && salario13 > 0 ? salario13 : 0m;

                    folhaDal.Inserir(folhaModel);

                    MessageBox.Show("Dados da Folha Inseridos com Sucesso!", "Aviso");

                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Não é possível inserir a folha. O funcionário não está ativo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimparCampos();
                }
            }

            tbSalarioBruto.Enabled = false;
            tbHorasExtras.Enabled = false;
            mtbMesAno.Enabled = false;
            cmbFuncionario.Enabled = false;
        }

        public void tbSalarioBruto_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(tbSalarioBruto.Text, out decimal salarioBruto))
            {
                // Calcula o percentual do INSS
                decimal percentualINSS = CalcularPercentualINSS(salarioBruto);

                // Atualiza o TextBox do percentual do INSS
                tbPercentualINSS.Text = percentualINSS.ToString("0.00");

                // Calcula o desconto do INSS
                decimal descontoINSS = CalcularDescontoINSS(salarioBruto, percentualINSS);

                // Calcula o valor do FGTS
                decimal percentualFGTS = 8m;
                decimal valorFGTS = CalcularValorFGTS(salarioBruto, percentualFGTS);

                // Atualiza o TextBox do valor do FGTS
                tbFgts.Text = valorFGTS.ToString("0.00");

                // Obtém as horas extras
                decimal horasExtras = decimal.TryParse(tbHorasExtras.Text, out decimal horasExtrasDigitadas) ? horasExtrasDigitadas : 0m;

                // Calcula o valor das horas extras
                decimal valorHorasExtras = CalcularValorHorasExtras(salarioBruto, horasExtras);

                decimal descontoTotal = descontoINSS + valorFGTS;

                folhaModel.Descontos_totais = descontoTotal;

                if (tbSalario13.Enabled)
                {

                    // Calcula o 13º salário
                    decimal salario13 = CalcularSalario13(salarioBruto);

                    // Atualiza o TextBox do 13º salário
                    tbSalario13.Text = salario13.ToString("0.00");

                    // Calcula o salário líquido considerando o 13º salário
                    decimal salarioLiquido = salarioBruto + valorHorasExtras - descontoINSS - valorFGTS + salario13;

                    // Atualiza o TextBox do salário líquido
                    tbSalarioLiquido.Text = salarioLiquido.ToString("0.00");
                }
                else
                {
                    // Se o campo do 13º salário não estiver habilitado, apenas calcula o salário líquido sem considerar o 13º
                    decimal salarioLiquido = salarioBruto + valorHorasExtras - descontoINSS - valorFGTS;

                    // Atualiza o TextBox do salário líquido
                    tbSalarioLiquido.Text = salarioLiquido.ToString("0.00");
                }
            }
        }

        private void mtbMesAno_TextChanged(object sender, EventArgs e)
        {
            if (mtbMesAno.MaskCompleted)
            {
                // Obtém o mês do campo "mes/ano"
                int mes;
                if (int.TryParse(mtbMesAno.Text.Substring(0, 2), out mes))
                {
                    // Habilita/desabilita o campo do 13º salário com base no mês
                    tbSalario13.Enabled = (mes == 12);

                    if (tbSalario13.Enabled)
                    {
                        tbSalario13.BackColor = Color.White;
                    }

                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", "Excluir", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                folhaModel.Id_funcionario = (int)cmbFuncionario.SelectedValue;
                folhaModel.Mes_ano = mtbMesAno.Text;
                folhaDal.Excluir(folhaModel.Id_funcionario, folhaModel.Mes_ano);

                MessageBox.Show("Dados Excluidos com Sucesso!");
            }
            LimparCampos();
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmFolhaPesquisa frmFolhaPesquisa = new frmFolhaPesquisa();

            if (frmFolhaPesquisa.ShowDialog() == DialogResult.OK)
            {
                mtbMesAno.Text = frmFolhaPesquisa.folhaModel.Mes_ano.ToString();

                clsFuncionariosDal funcionariosDal = new clsFuncionariosDal();

                cmbFuncionario.DisplayMember = "nome";
                cmbFuncionario.ValueMember = "id_funcionario";
                cmbFuncionario.DataSource = funcionariosDal.ListarTodos();

                // Seleciona o valor correspondente ao Id_funcionario
                cmbFuncionario.SelectedValue = frmFolhaPesquisa.folhaModel.Id_funcionario.ToString();

                tbHorasExtras.Text = frmFolhaPesquisa.folhaModel.Hora_extra.ToString();
                tbSalarioBruto.Text = frmFolhaPesquisa.folhaModel.Salario.ToString();
                tbSalario13.Text = frmFolhaPesquisa.folhaModel.Salario_13.ToString();
                tbPercentualINSS.Text = frmFolhaPesquisa.folhaModel.Percentual_inss.ToString();
                tbFgts.Text = frmFolhaPesquisa.folhaModel.Fgts.ToString();
                tbSalarioLiquido.Text = frmFolhaPesquisa.folhaModel.Salario_liquido.ToString();

            }

            btnExcluir.Enabled = true;
        }

        private void tbHorasExtras_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(tbSalarioBruto.Text, out decimal salarioBruto))
            {
                // Calcula o percentual do INSS
                decimal percentualINSS = CalcularPercentualINSS(salarioBruto);

                // Calcula o desconto do INSS
                decimal descontoINSS = CalcularDescontoINSS(salarioBruto, percentualINSS);

                // Calcula o valor do FGTS
                decimal percentualFGTS = 8m;
                decimal valorFGTS = CalcularValorFGTS(salarioBruto, percentualFGTS);

                // Obtém as horas extras
                decimal horasExtras = decimal.TryParse(tbHorasExtras.Text, out decimal horasExtrasDigitadas) ? horasExtrasDigitadas : 0m;

                // Calcula o valor das horas extras
                decimal valorHorasExtras = CalcularValorHorasExtras(salarioBruto, horasExtras);

                if (tbSalario13.Enabled)
                {

                    // Calcula o 13º salário
                    decimal salario13 = CalcularSalario13(salarioBruto);

                    // Atualiza o TextBox do 13º salário
                    tbSalario13.Text = salario13.ToString("0.00");

                    // Calcula o salário líquido considerando o 13º salário
                    decimal salarioLiquido = salarioBruto + valorHorasExtras - descontoINSS - valorFGTS + salario13;

                    // Atualiza o TextBox do salário líquido
                    tbSalarioLiquido.Text = salarioLiquido.ToString("0.00");
                }
                else
                {
                    // Se o campo do 13º salário não estiver habilitado, apenas calcula o salário líquido sem considerar o 13º
                    decimal salarioLiquido = salarioBruto + valorHorasExtras - descontoINSS - valorFGTS;

                    // Atualiza o TextBox do salário líquido
                    tbSalarioLiquido.Text = salarioLiquido.ToString("0.00");
                }
            }
        }
    }
}
