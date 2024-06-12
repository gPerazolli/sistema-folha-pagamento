using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using cl_dal;
using cl_models;
using System.Data.SqlClient;

namespace ui_wfa_folha
{
    public partial class frmCadastroFuncionario : Form
    {

        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataAdapter _adptador;
        private DataTable _tabela;
        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }

        clsFuncionariosModel funcionariosModel = new clsFuncionariosModel();
        clsFuncionariosDal funcionariosDal = new clsFuncionariosDal();

        public void LimparCampos()
        {
            tbId.Text = "";
            tbNome.Text = "";
            mtbCpf.Text = "";
            tbCargo.Text = "";
            mtbCtps.Text = "";
            dtAdmissao.Value = DateTime.Now;
        }

        private void AtivarFormulario()
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnPesquisar.Enabled = true;

            tbNome.Enabled = false;
            tbCargo.Enabled = false;
            mtbCpf.Enabled = false;
            mtbCtps.Enabled = false;
            dtAdmissao.Enabled = false;
            cbSituacao.Enabled = false;
        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            AtivarFormulario();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnPesquisar.Enabled = false;

            LimparCampos();
            tbNome.Focus();

            tbNome.Enabled = true;
            tbCargo.Enabled = true;
            mtbCpf.Enabled = true;
            mtbCtps.Enabled = true;
            dtAdmissao.Enabled = true;
            cbSituacao.Enabled = true;

            cbSituacao.Checked = true;
            cbSituacao.Visible = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnPesquisar.Enabled = false;

            tbNome.Focus();

            tbNome.Enabled = true;
            tbCargo.Enabled = true;
            mtbCpf.Enabled = true;
            mtbCtps.Enabled = true;
            dtAdmissao.Enabled = true;
            cbSituacao.Enabled = true;

            cbSituacao.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnPesquisar.Enabled = true;

            LimparCampos();

            tbNome.Enabled = false;
            tbCargo.Enabled = false;
            mtbCpf.Enabled = false;
            mtbCtps.Enabled = false;
            dtAdmissao.Enabled = false;
            cbSituacao.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnPesquisar.Enabled = true;

            if (tbId.Text == "")
            {
                funcionariosModel.Nome = tbNome.Text;
                funcionariosModel.Cpf = mtbCpf.Text;
                funcionariosModel.Cargo = tbCargo.Text;
                funcionariosModel.Ctps = mtbCtps.Text;
                funcionariosModel.Situacao = cbSituacao.Checked;

                if (DateTime.TryParse(dtAdmissao.Text, out DateTime dataAdmissao))
                {
                    funcionariosModel.Data_admissao = dataAdmissao;
                }

                funcionariosDal.Inserir(funcionariosModel);

                MessageBox.Show("Dados dos Funcionarios Inseridos com Sucesso!!", "Aviso");

                LimparCampos();
            }
            else
            {
                funcionariosModel.Id_funcionario = int.Parse(tbId.Text);
                funcionariosModel.Nome = tbNome.Text;
                funcionariosModel.Cpf = mtbCpf.Text;
                funcionariosModel.Cargo = tbCargo.Text;
                funcionariosModel.Ctps = mtbCtps.Text;

                if (DateTime.TryParse(dtAdmissao.Text, out DateTime dataAdmissao))
                {
                    funcionariosModel.Data_admissao = dataAdmissao;
                }

                funcionariosDal.Atualizar(funcionariosModel);

                MessageBox.Show("Dados dos Funcionarios Atualizados com Sucesso!!", "Aviso");

                LimparCampos();
            }

            tbNome.Enabled = false;
            tbCargo.Enabled = false;
            mtbCpf.Enabled = false;
            mtbCtps.Enabled = false;
            dtAdmissao.Enabled = false;
            cbSituacao.Enabled = false;
        }

        private void cbSituacao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSituacao.Checked)
            {
                funcionariosModel.Situacao = true;
            }
            else
            {
                funcionariosModel.Situacao = false;
            }
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            frmFuncionariosPesquisa funcionariosPesquisa = new frmFuncionariosPesquisa();

            if (funcionariosPesquisa.ShowDialog() == DialogResult.OK)
            {
                tbId.Text = funcionariosPesquisa.funcionariosModel.Id_funcionario.ToString();
                tbNome.Text = funcionariosPesquisa.funcionariosModel.Nome.ToString();
                mtbCpf.Text = funcionariosPesquisa.funcionariosModel.Cpf.ToString();
                tbCargo.Text = funcionariosPesquisa.funcionariosModel.Cargo.ToString();
                mtbCtps.Text = funcionariosPesquisa.funcionariosModel.Ctps.ToString();

                if (DateTime.TryParse(funcionariosPesquisa.funcionariosModel.Data_admissao.ToString(), out DateTime dataAdmissao))
                {
                    dtAdmissao.Value = dataAdmissao;
                }

                if (bool.TryParse(funcionariosPesquisa.funcionariosModel.Situacao.ToString(), out bool situacao))
                {
                    cbSituacao.Checked = situacao;
                }
                else
                {
                    cbSituacao.Checked = false;
                }
            }
            cbSituacao.Visible = true;
        }
    }
}

