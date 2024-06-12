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
    public partial class frmCadastroUsuarios : Form
    {
        clsUsuariosDal usuariosDal = new clsUsuariosDal();
        clsUsuariosModel usuariosModel = new clsUsuariosModel();

        public frmCadastroUsuarios()
        {
            InitializeComponent();
        }

        private void frmCadastroUsuarios_Load(object sender, EventArgs e)
        {
            AtivarFormulario();
        }

        private void LimparCampos()
        {
            tbId.Text = "";
            tbNome.Text = "";
            tbLogin.Text = "";
            tbSenha.Text = "";
            tbConfirmarSenha.Text = "";
        }

        private void AtivarFormulario()
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnPesquisar.Enabled = true;

            tbNome.Enabled = false;
            tbLogin.Enabled = false;
            tbConfirmarSenha.Enabled = false;
            tbSenha.Enabled = false;
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
            tbLogin.Enabled = true;
            tbConfirmarSenha.Enabled = true;
            tbSenha.Enabled = true;
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
            tbLogin.Enabled = true;
            tbConfirmarSenha.Enabled = true;
            tbSenha.Enabled = true;
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
            tbLogin.Enabled = false;
            tbConfirmarSenha.Enabled = false;
            tbSenha.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", "Excluir", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                usuariosModel.Id_usu = int.Parse(tbId.Text);
                usuariosDal.Excluir(usuariosModel.Id_usu);

                MessageBox.Show("Dados Excluidos com Sucesso!");
            }
            LimparCampos();
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnPesquisar.Enabled = true;

            if (tbId.Text != "" && tbSenha.Text == tbConfirmarSenha.Text)
            {
                usuariosModel.Id_usu = int.Parse(tbId.Text);
                usuariosModel.Nome_usu = tbNome.Text;
                usuariosModel.Login_usu = tbLogin.Text;
                usuariosModel.Senha_usu = tbSenha.Text;

                usuariosDal.Atualizar(usuariosModel);

                MessageBox.Show("Dados dos Usuarios Atualizados com Sucesso!", "Aviso");

                LimparCampos();
            }
            else if (tbSenha.Text == tbConfirmarSenha.Text)
            {
                usuariosModel.Nome_usu = tbNome.Text;
                usuariosModel.Login_usu = tbLogin.Text;
                usuariosModel.Senha_usu = tbSenha.Text;

                usuariosDal.Inserir(usuariosModel);

                MessageBox.Show("Dados dos Usuarios Inseridos com Sucesso!", "Aviso");

                LimparCampos();
            }
            else if (tbSenha.Text != tbConfirmarSenha.Text)
            {
                MessageBox.Show("Senha Inválida!");

                tbSenha.Text = "";
                tbConfirmarSenha.Text = "";

                tbSenha.Focus();
            }

            tbNome.Enabled = false;
            tbLogin.Enabled = false;
            tbConfirmarSenha.Enabled = false;
            tbSenha.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmUsuariosPesquisa usuariosPesquisa = new frmUsuariosPesquisa();

            if(usuariosPesquisa.ShowDialog() == DialogResult.OK)
            {
                tbId.Text = usuariosPesquisa.usuariosModel.Id_usu.ToString();
                tbNome.Text = usuariosPesquisa.usuariosModel.Nome_usu.ToString();
                tbLogin.Text = usuariosPesquisa.usuariosModel.Login_usu.ToString();
                tbSenha.Text = usuariosPesquisa.usuariosModel.Senha_usu.ToString();
                tbConfirmarSenha.Text = usuariosPesquisa.usuariosModel.Senha_usu.ToString();
            }
        }
    }
}
