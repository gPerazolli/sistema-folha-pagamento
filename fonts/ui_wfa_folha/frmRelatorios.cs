using cl_dal;
using cl_models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui_wfa_folha
{
    public partial class frmRelatorios : Form
    {

        clsFuncionariosDal funcionariosDal = new clsFuncionariosDal();
        clsFuncionariosModel funcionariosModel = new clsFuncionariosModel();
        clsFolhaModel folhaModel = new clsFolhaModel();
        clsFolhaDal folhaDal = new clsFolhaDal();


        public frmRelatorios()
        {
            InitializeComponent();
        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            clsFuncionariosDal funcionariosDal = new clsFuncionariosDal();

            cmbFuncionario.DataSource = funcionariosDal.ListarTodos();
            cmbFuncionario.DisplayMember = "nome";
            cmbFuncionario.ValueMember = "id_funcionario";
            cmbFuncionario.SelectedIndex = -1;

            dateFuncionario.Format = DateTimePickerFormat.Custom;
            dateFuncionario.CustomFormat = "MM/yyyy";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            listRelatorio.Items.Clear();

            if (cmbFuncionario.SelectedIndex != -1)
            {
                // Obtém o ID do funcionário selecionado
                int idFuncionario = (int)cmbFuncionario.SelectedValue;

                DateTime mesAnoSelecionado = new DateTime(dateFuncionario.Value.Year, dateFuncionario.Value.Month, 1);
                string mesAnoFormatado = mesAnoSelecionado.ToString("MM/yyyy"); // Formata para "MM/yyyy"


                // Obtém as informações do funcionário do banco de dados usando o método ObterPorId da sua classe clsFuncionariosDal
                clsFuncionariosModel funcionarioSelecionado = funcionariosDal.ObterPorId(idFuncionario);
                clsFolhaModel folhaFuncionario = folhaDal.ObterPorId(idFuncionario, mesAnoFormatado);
                
                // Verifica se o funcionário foi encontrado
                if (funcionarioSelecionado != null && folhaFuncionario != null)
                {
                    listRelatorio.Items.Add($"----------------------------------------------");
                    listRelatorio.Items.Add($"|| RELATÓRIO DO FUNCIONÁRIO ||");
                    listRelatorio.Items.Add($"----------------------------------------------");
                    listRelatorio.Items.Add($"== NOME: {funcionarioSelecionado.Nome} ==");
                    listRelatorio.Items.Add($"ID: {funcionarioSelecionado.Id_funcionario}");
                    listRelatorio.Items.Add($"CPF: {funcionarioSelecionado.Cpf}");
                    listRelatorio.Items.Add($"Cargo: {funcionarioSelecionado.Cargo}");
                    listRelatorio.Items.Add($"Data de Admissão: {funcionarioSelecionado.Data_admissao.ToShortDateString()}");
                    listRelatorio.Items.Add($"CTPS: {funcionarioSelecionado.Ctps}");
                    listRelatorio.Items.Add($"Situação: {(funcionarioSelecionado.Situacao ? "Ativo" : "Inativo")}");
                    listRelatorio.Items.Add($"Mês/ano do Pagamento: {folhaFuncionario.Mes_ano}");
                    listRelatorio.Items.Add($"----------------------------------------------");
                    listRelatorio.Items.Add($"INSS: {folhaFuncionario.Percentual_inss}%");
                    listRelatorio.Items.Add($"Hora(s) Extra(s) feita(s) no mês: {folhaFuncionario.Hora_extra}");
                    listRelatorio.Items.Add($"Total do FGTS descontado: R$ {folhaFuncionario.Fgts},00");
                    listRelatorio.Items.Add($"Descontos Total: R$ {folhaFuncionario.Descontos_totais}");
                    listRelatorio.Items.Add($"");
                    listRelatorio.Items.Add($"##SALÁRIO BRUTO: R$ {folhaFuncionario.Salario}##");
                    listRelatorio.Items.Add($"##SALÁRIO LIQUÍDO: R$ {folhaFuncionario.Salario_liquido}##");
                    listRelatorio.Items.Add($"----------------------------------------------");
                }
                else
                {
                    MessageBox.Show("Funcionário não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionário antes de gerar o relatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
