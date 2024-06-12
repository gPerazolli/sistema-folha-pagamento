using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace ui_wfa_folha
{
    public partial class frmPrincipal : Form
    {
        Thread nt;

        public frmPrincipal()
        {
            InitializeComponent();
            ConfigurarStatusStrip();
        }
        public frmPrincipal(string nomeUsuario)
        {
            InitializeComponent();

            lbBemVindo.Text = $"Seja bem-vindo(a), {nomeUsuario}";

            if (nomeUsuario.ToLower() == "admin")
            {
                cadastroToolStripMenuItem1.Enabled = true;
            }
            else
            {
                cadastroToolStripMenuItem1.Enabled = false;
            }
        }

        private void ConfigurarStatusStrip()
        {
            // Adicionar uma mola (ToolStripStatusLabel)
            ToolStripStatusLabel mola = new ToolStripStatusLabel();
            mola.Spring = true;
            statusStrip.Items.Add(mola);

            // Adicionar o ToolStripStatusLabel no final
            ToolStripStatusLabel labelDireita = new ToolStripStatusLabel("|| www.folhasys.com.br ");
            statusStrip.Items.Add(labelDireita);
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario frmFuncionario = new frmCadastroFuncionario();
            frmFuncionario.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            DateTime dataAtual = DateTime.Now;

            string dataPorExtenso = dataAtual.ToString("dddd, d 'de' MMMM 'de' yyyy ' - ' HH:mm", new CultureInfo("pt-BR"));

            // Converter a primeira letra do dia da semana e do mês em maiúsculas
            dataPorExtenso = char.ToUpper(dataPorExtenso[0]) + dataPorExtenso.Substring(1);
            int indexMes = dataPorExtenso.IndexOf(" de ");
            if (indexMes > 0 && indexMes + 4 < dataPorExtenso.Length)
            {
                dataPorExtenso = dataPorExtenso.Substring(0, indexMes + 4) + char.ToUpper(dataPorExtenso[indexMes + 4]) + dataPorExtenso.Substring(indexMes + 5);
            }

            lbData.Text = dataPorExtenso;
        }

        private void folhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFolha frmFolha = new frmFolha();
            frmFolha.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataAtual = DateTime.Now;

            string dataPorExtenso = dataAtual.ToString("dddd, d 'de' MMMM 'de' yyyy ' - ' HH:mm", new CultureInfo("pt-BR"));

            // Converter a primeira letra do dia da semana e do mês em maiúsculas
            dataPorExtenso = char.ToUpper(dataPorExtenso[0]) + dataPorExtenso.Substring(1);
            int indexMes = dataPorExtenso.IndexOf(" de ");
            if (indexMes > 0 && indexMes + 4 < dataPorExtenso.Length)
            {
                dataPorExtenso = dataPorExtenso.Substring(0, indexMes + 4) + char.ToUpper(dataPorExtenso[indexMes + 4]) + dataPorExtenso.Substring(indexMes + 5);
            }

            lbData.Text = dataPorExtenso;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Encerrar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(LogOff);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.AcceptButton = null;
        }

        private void LogOff()
        {
            Application.Run(new frmLogin());
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroUsuarios cadastroUsuarios = new frmCadastroUsuarios();
            cadastroUsuarios.ShowDialog();
        }

        private void folhaDosFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorios relatorios = new frmRelatorios();
            relatorios.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSuporteTecnico suporteTecnico = new frmSuporteTecnico();
            suporteTecnico.ShowDialog();
        }
    }
}