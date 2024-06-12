using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using cl_dal;

namespace ui_wfa_folha
{
    public partial class frmLogin : Form
    {
        Thread nt;
        public frmLogin()
        {
            InitializeComponent();
        }

        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataReader _reader;

        public string nomeusuario = "";

        private void frmLogin_Load(object sender, EventArgs e)
        {
            tbLogin.Focus();
        }

        private void Logar()
        {
            string usuario, senha;

            string login = "select login_usu, senha_usu from usuarios where login_usu = '" + tbLogin.Text + "' and senha_usu = '" + tbSenha.Text + "'";
            try
            {
                _conexao = clsConnection.obterConexao();
                _comandos = new SqlCommand(login, _conexao);
                _comandos.CommandType = CommandType.Text;

                if(_conexao.State != ConnectionState.Open)
                {
                    _conexao.Open(); // abre a conexao apenas se nao tiver aberta 
                }

                _reader = _comandos.ExecuteReader();

                if (_reader.Read())
                {

                    usuario = _reader[0].ToString();
                    senha = _reader[1].ToString();


                    if (usuario == tbLogin.Text && senha == tbSenha.Text)
                    {
                        nomeusuario = tbLogin.Text;

                        this.Close();
                        nt = new Thread(Logado);
                        nt.SetApartmentState(ApartmentState.STA);
                        nt.Start();
                    }
                }
                else
                {
                    MessageBox.Show("Login e/ou senha invalidos");
                    tbLogin.Text = "";
                    tbSenha.Text = "";
                    tbLogin.Focus();

                }

                _conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar realizar login: " + ex.Message);
                _conexao.Close();
            }
            finally
            {
                if(_conexao != null && _conexao.State == ConnectionState.Open)
                {
                    _conexao.Close();
                }
                
            }
        }

        private void Logado()
        {
            Application.Run(new frmPrincipal(nomeusuario));
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que desja sair?", "Encerrar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
