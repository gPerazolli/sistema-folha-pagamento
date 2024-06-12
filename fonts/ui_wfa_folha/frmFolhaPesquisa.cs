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
    public partial class frmFolhaPesquisa : Form
    {

        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataAdapter _adptador;
        private DataTable _tabela;

        public clsFolhaDal folhaDal;
        public clsFolhaModel folhaModel;

        public frmFolhaPesquisa()
        {
            InitializeComponent();
        }

        private void frmFolhaPesquisa_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FormatarGrid();

            btnBuscar.Enabled = false;
            tbBusca.Enabled = false;
        }

        private void CarregarGrid()
        {
            folhaDal = new clsFolhaDal();
            gridFolha.DataSource = folhaDal.ListarTodos();
        }

        private void FormatarGrid()
        {
            gridFolha.ReadOnly = true;
            gridFolha.ScrollBars = ScrollBars.Both;
            gridFolha.Columns[0].HeaderText = "MÊS/ANO";
            gridFolha.Columns[1].HeaderText = "ID FUNCIONARIO";
            gridFolha.Columns[2].HeaderText = "SALARIO";
            gridFolha.Columns[3].HeaderText = "% INSS";
            gridFolha.Columns[4].HeaderText = "HORA EXTRA";
            gridFolha.Columns[5].HeaderText = "SALARIO COM HORA EXTRA";
            gridFolha.Columns[6].HeaderText = "DESCONTOS TOTAIS";
            gridFolha.Columns[7].HeaderText = "SALARIO LIQUIDO";
            gridFolha.Columns[8].HeaderText = "DECIMO TERCEIRO";
            gridFolha.Columns[9].HeaderText = "FGTS";

            gridFolha.Columns[0].Width = 90;
            gridFolha.Columns[1].Width = 110;
            gridFolha.Columns[2].Width = 100;
            gridFolha.Columns[3].Width = 60;
            gridFolha.Columns[4].Width = 70;
            gridFolha.Columns[5].Width = 120;
            gridFolha.Columns[6].Width = 100;
            gridFolha.Columns[7].Width = 100;
            gridFolha.Columns[8].Width = 100;
            gridFolha.Columns[9].Width = 80;
        }

        public void SelecionarItem()
        {
            Int32 i = 0;

            folhaDal = new clsFolhaDal();
            folhaModel = new clsFolhaModel();

            if (gridFolha.CurrentRow != null)
            {
                i = gridFolha.CurrentRow.Index;
                folhaModel.Mes_ano = gridFolha[0, i].Value.ToString();
                folhaModel.Id_funcionario = int.Parse(gridFolha[1, i].Value.ToString());
                folhaModel.Salario = decimal.Parse(gridFolha[2, i].Value.ToString());
                folhaModel.Percentual_inss = float.Parse(gridFolha[3, i].Value.ToString());
                folhaModel.Hora_extra = int.Parse(gridFolha[4, i].Value.ToString());
                folhaModel.Salario_hora_extra = decimal.Parse(gridFolha[5, i].Value.ToString());
                folhaModel.Salario_liquido = decimal.Parse(gridFolha[7, i].Value.ToString());
                folhaModel.Salario_13 = decimal.Parse(gridFolha[8, i].Value.ToString());
                folhaModel.Fgts = float.Parse(gridFolha[9, i].Value.ToString());
            }
            this.DialogResult = DialogResult.OK;
        }

        private void Buscar()
        {
            _conexao = clsConnection.obterConexao();

            if (rbMesAno.Checked)
            {
                var nome = "select * from folha where mes_ano LIKE '%" + tbBusca.Text + "%'";

                _adptador = new SqlDataAdapter(nome, _conexao);

                _tabela = new DataTable();

                _adptador.Fill(_tabela);
                gridFolha.DataSource = _tabela;
            }
            else if (rbId.Checked)
            {
                var id = "select * from folha where id_funcionario = '" + tbBusca.Text + "'";

                _adptador = new SqlDataAdapter(id, _conexao);

                _tabela = new DataTable();

                _adptador.Fill(_tabela);
                gridFolha.DataSource = _tabela;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.folhaModel = new clsFolhaModel();

            this.folhaModel.Mes_ano = "";
            this.folhaModel.Id_funcionario = 0;
            this.folhaModel.Salario = 0;
            this.folhaModel.Percentual_inss = 0;
            this.folhaModel.Hora_extra = 0;
            this.folhaModel.Salario_hora_extra = 0;
            this.folhaModel.Salario_liquido = 0;
            this.folhaModel.Salario_13 = 0;
            this.folhaModel.Fgts = 0;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            SelecionarItem();
            this.Close();
        }

        private void rbMesAno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMesAno.Checked)
            {
                btnBuscar.Enabled = true;
                tbBusca.Enabled = true;
            }
        }

        private void rbId_CheckedChanged(object sender, EventArgs e)
        {
            if (rbId.Checked)
            {
                btnBuscar.Enabled = true;
                tbBusca.Enabled = true;
            }
        }
    }
}
