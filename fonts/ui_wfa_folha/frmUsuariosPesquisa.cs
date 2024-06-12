using cl_dal;
using cl_models;
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

namespace ui_wfa_folha
{
    public partial class frmUsuariosPesquisa : Form
    {
        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataAdapter _adptador;
        private DataTable _tabela;

        public clsUsuariosModel usuariosModel;
        public clsUsuariosDal usuariosDal;

        public frmUsuariosPesquisa()
        {
            InitializeComponent();
        }

        private void frmUsuariosPesquisa_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FormatarGrid();

            btnBuscar.Enabled = false;
            tbBusca.Enabled = false;
        }

        private void CarregarGrid()
        {
            usuariosDal = new clsUsuariosDal();
            gridUsuarios.DataSource = usuariosDal.ListarTodos();
        }

        private void FormatarGrid()
        {
            gridUsuarios.ReadOnly = true;
            gridUsuarios.ScrollBars = ScrollBars.Both;
            gridUsuarios.Columns[0].HeaderText = "ID";
            gridUsuarios.Columns[1].HeaderText = "NOME";
            gridUsuarios.Columns[2].HeaderText = "LOGIN";
            gridUsuarios.Columns[3].HeaderText = "SENHA";

            gridUsuarios.Columns[0].Width = 50;
            gridUsuarios.Columns[1].Width = 200;
            gridUsuarios.Columns[2].Width = 120;
            gridUsuarios.Columns[3].Width = 100;

        }

        public void SelecionarItem()
        {
            Int32 i = 0;

            usuariosDal = new clsUsuariosDal();
            usuariosModel = new clsUsuariosModel();

            if (gridUsuarios.CurrentRow != null)
            {
                i = gridUsuarios.CurrentRow.Index;
                usuariosModel.Id_usu = int.Parse(gridUsuarios[0, i].Value.ToString());
                usuariosModel.Nome_usu = gridUsuarios[1, i].Value.ToString();
                usuariosModel.Login_usu = gridUsuarios[2, i].Value.ToString();
                usuariosModel.Senha_usu = gridUsuarios[3, i].Value.ToString();

            }
            this.DialogResult = DialogResult.OK;
        }

        private void Buscar()
        {
            _conexao = clsConnection.obterConexao();

            if (rbNome.Checked)
            {
                var nome = "select * from usuarios where nome_usu LIKE '%" + tbBusca.Text + "%'";

                _adptador = new SqlDataAdapter(nome, _conexao);

                _tabela = new DataTable();

                _adptador.Fill(_tabela);
                gridUsuarios.DataSource = _tabela;
            }
            else if (rbId.Checked)
            {
                var id = "select * from usuarios where id_usu = '" + tbBusca.Text + "'";

                _adptador = new SqlDataAdapter(id, _conexao);

                _tabela = new DataTable();

                _adptador.Fill(_tabela);
                gridUsuarios.DataSource = _tabela;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.usuariosModel = new clsUsuariosModel();

            this.usuariosModel.Id_usu = 0;
            this.usuariosModel.Nome_usu = "";
            this.usuariosModel.Login_usu = "";
            this.usuariosModel.Senha_usu = "";

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            SelecionarItem();
            this.Close();
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNome.Checked)
            {
                btnBuscar.Enabled = true;
                tbBusca.Enabled = true;
            }
        }

        private void rbId_CheckedChanged(object sender, EventArgs e)
        {
            if(rbId.Checked)
            {
                btnBuscar.Enabled = true;
                tbBusca.Enabled = true;
            }
        }
    }
}
