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
using cl_models;

namespace ui_wfa_folha
{
    public partial class frmFuncionariosPesquisa : Form
    {

        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataAdapter _adptador;
        private DataTable _tabela;

        public frmFuncionariosPesquisa()
        {
            InitializeComponent();
        }

        public clsFuncionariosModel funcionariosModel;
        public clsFuncionariosDal funcionarioDal;

        private void CarregarGrid()
        {
            funcionarioDal = new clsFuncionariosDal();
            gridFuncionarios.DataSource = funcionarioDal.ListarTodos();
        }

        private void FormatarGrid()
        {
            gridFuncionarios.ReadOnly = true;
            gridFuncionarios.ScrollBars = ScrollBars.Both;
            gridFuncionarios.Columns[0].HeaderText = "ID";
            gridFuncionarios.Columns[1].HeaderText = "NOME";
            gridFuncionarios.Columns[2].HeaderText = "CPF";
            gridFuncionarios.Columns[3].HeaderText = "CARGO";
            gridFuncionarios.Columns[4].HeaderText = "DATA DE ADMISSÃO";
            gridFuncionarios.Columns[5].HeaderText = "CTPS";
            gridFuncionarios.Columns[6].HeaderText = "SITUAÇÃO";

            gridFuncionarios.Columns[0].Width = 50;
            gridFuncionarios.Columns[1].Width = 300;
            gridFuncionarios.Columns[2].Width = 120;
            gridFuncionarios.Columns[3].Width = 150;
            gridFuncionarios.Columns[4].Width = 100;
            gridFuncionarios.Columns[5].Width = 120;
            gridFuncionarios.Columns[6].Width = 80;
        }

        public void SelecionarItem()
        {
            Int32 i = 0;

            funcionarioDal = new clsFuncionariosDal();
            funcionariosModel = new clsFuncionariosModel();

            if (gridFuncionarios.CurrentRow != null)
            {
                i = gridFuncionarios.CurrentRow.Index;
                funcionariosModel.Id_funcionario = int.Parse(gridFuncionarios[0, i].Value.ToString());
                funcionariosModel.Nome = gridFuncionarios[1, i].Value.ToString();
                funcionariosModel.Cpf = gridFuncionarios[2, i].Value.ToString();
                funcionariosModel.Cargo = gridFuncionarios[3, i].Value.ToString();

                if (DateTime.TryParse(gridFuncionarios[4, i].Value.ToString(), out DateTime dataAdmissao))
                {
                    funcionariosModel.Data_admissao = dataAdmissao;
                }
                funcionariosModel.Ctps = gridFuncionarios[5, i].Value.ToString();
                if (bool.TryParse(gridFuncionarios[6, i].Value.ToString(), out bool situacao))
                {
                    funcionariosModel.Situacao = situacao;
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscar()
        {
            _conexao = clsConnection.obterConexao();

            if (rbNome.Checked)
            {
                var nome = "select * from funcionarios where nome LIKE '%" + tbBusca.Text + "%'";

                _adptador = new SqlDataAdapter(nome, _conexao);

                _tabela = new DataTable();

                _adptador.Fill(_tabela);
                gridFuncionarios.DataSource = _tabela;
            }
            else if (rbId.Checked)
            {
                var id = "select * from funcionarios where id_funcionario = '" + tbBusca.Text + "'";

                _adptador = new SqlDataAdapter(id, _conexao);

                _tabela = new DataTable();

                _adptador.Fill(_tabela);
                gridFuncionarios.DataSource = _tabela;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmFuncionariosPesquisa_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FormatarGrid();

            btnBuscar.Enabled = false;
            tbBusca.Enabled = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.funcionariosModel = new clsFuncionariosModel();

            this.funcionariosModel.Id_funcionario = 0;
            this.funcionariosModel.Nome = "";
            this.funcionariosModel.Cpf = "";
            this.funcionariosModel.Cargo = "";
            this.funcionariosModel.Ctps = "";
            this.funcionariosModel.Data_admissao = DateTime.Now;

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

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            if (rbId.Checked)
            {
                btnBuscar.Enabled = true;
                tbBusca.Enabled = true;
            }
        }
    }
}
