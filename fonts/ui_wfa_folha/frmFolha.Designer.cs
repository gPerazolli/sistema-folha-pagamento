namespace ui_wfa_folha
{
    partial class frmFolha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolha));
            btnSalvar = new Button();
            gbDados = new GroupBox();
            lbSalarioLiquido = new Label();
            tbSalarioLiquido = new TextBox();
            lbSalario13 = new Label();
            tbSalario13 = new TextBox();
            lbHorasExtras = new Label();
            tbHorasExtras = new TextBox();
            lbFgts = new Label();
            tbFgts = new TextBox();
            mtbMesAno = new MaskedTextBox();
            cmbFuncionario = new ComboBox();
            lbPercentualINSS = new Label();
            tbPercentualINSS = new TextBox();
            lbMesAno = new Label();
            lbSalarioBruto = new Label();
            tbSalarioBruto = new TextBox();
            lbNome = new Label();
            btnPesquisar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnNovo = new Button();
            btnExcluir = new Button();
            gbDados.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.White;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(210, 83);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(97, 50);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // gbDados
            // 
            gbDados.BackColor = Color.LightGray;
            gbDados.Controls.Add(lbSalarioLiquido);
            gbDados.Controls.Add(tbSalarioLiquido);
            gbDados.Controls.Add(lbSalario13);
            gbDados.Controls.Add(tbSalario13);
            gbDados.Controls.Add(lbHorasExtras);
            gbDados.Controls.Add(tbHorasExtras);
            gbDados.Controls.Add(lbFgts);
            gbDados.Controls.Add(tbFgts);
            gbDados.Controls.Add(mtbMesAno);
            gbDados.Controls.Add(cmbFuncionario);
            gbDados.Controls.Add(lbPercentualINSS);
            gbDados.Controls.Add(tbPercentualINSS);
            gbDados.Controls.Add(lbMesAno);
            gbDados.Controls.Add(lbSalarioBruto);
            gbDados.Controls.Add(tbSalarioBruto);
            gbDados.Controls.Add(lbNome);
            gbDados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbDados.Location = new Point(31, 151);
            gbDados.Name = "gbDados";
            gbDados.Size = new Size(676, 305);
            gbDados.TabIndex = 10;
            gbDados.TabStop = false;
            gbDados.Text = "Dados";
            // 
            // lbSalarioLiquido
            // 
            lbSalarioLiquido.AutoSize = true;
            lbSalarioLiquido.Location = new Point(462, 208);
            lbSalarioLiquido.Name = "lbSalarioLiquido";
            lbSalarioLiquido.Size = new Size(116, 20);
            lbSalarioLiquido.TabIndex = 22;
            lbSalarioLiquido.Text = "Salario Liquido:";
            // 
            // tbSalarioLiquido
            // 
            tbSalarioLiquido.BackColor = SystemColors.InactiveCaption;
            tbSalarioLiquido.Enabled = false;
            tbSalarioLiquido.Location = new Point(424, 231);
            tbSalarioLiquido.Name = "tbSalarioLiquido";
            tbSalarioLiquido.Size = new Size(188, 27);
            tbSalarioLiquido.TabIndex = 0;
            // 
            // lbSalario13
            // 
            lbSalario13.AutoSize = true;
            lbSalario13.Location = new Point(281, 111);
            lbSalario13.Name = "lbSalario13";
            lbSalario13.Size = new Size(89, 20);
            lbSalario13.TabIndex = 20;
            lbSalario13.Text = "13º Salario:";
            // 
            // tbSalario13
            // 
            tbSalario13.BackColor = SystemColors.InactiveCaption;
            tbSalario13.Enabled = false;
            tbSalario13.Location = new Point(281, 134);
            tbSalario13.Name = "tbSalario13";
            tbSalario13.PlaceholderText = "0";
            tbSalario13.Size = new Size(188, 27);
            tbSalario13.TabIndex = 0;
            // 
            // lbHorasExtras
            // 
            lbHorasExtras.AutoSize = true;
            lbHorasExtras.Location = new Point(523, 111);
            lbHorasExtras.Name = "lbHorasExtras";
            lbHorasExtras.Size = new Size(101, 20);
            lbHorasExtras.TabIndex = 18;
            lbHorasExtras.Text = "Horas Extras:";
            // 
            // tbHorasExtras
            // 
            tbHorasExtras.BackColor = SystemColors.Window;
            tbHorasExtras.Location = new Point(523, 134);
            tbHorasExtras.Name = "tbHorasExtras";
            tbHorasExtras.PlaceholderText = "0";
            tbHorasExtras.Size = new Size(115, 27);
            tbHorasExtras.TabIndex = 3;
            tbHorasExtras.TextChanged += tbHorasExtras_TextChanged;
            // 
            // lbFgts
            // 
            lbFgts.AutoSize = true;
            lbFgts.Location = new Point(151, 208);
            lbFgts.Name = "lbFgts";
            lbFgts.Size = new Size(49, 20);
            lbFgts.TabIndex = 16;
            lbFgts.Text = "FGTS:";
            // 
            // tbFgts
            // 
            tbFgts.BackColor = SystemColors.InactiveCaption;
            tbFgts.Enabled = false;
            tbFgts.Location = new Point(151, 231);
            tbFgts.Name = "tbFgts";
            tbFgts.Size = new Size(115, 27);
            tbFgts.TabIndex = 0;
            // 
            // mtbMesAno
            // 
            mtbMesAno.BackColor = SystemColors.Window;
            mtbMesAno.Location = new Point(23, 62);
            mtbMesAno.Mask = "##/####";
            mtbMesAno.Name = "mtbMesAno";
            mtbMesAno.Size = new Size(69, 27);
            mtbMesAno.TabIndex = 1;
            mtbMesAno.TextChanged += mtbMesAno_TextChanged;
            // 
            // cmbFuncionario
            // 
            cmbFuncionario.BackColor = SystemColors.Window;
            cmbFuncionario.FormattingEnabled = true;
            cmbFuncionario.Location = new Point(162, 61);
            cmbFuncionario.Name = "cmbFuncionario";
            cmbFuncionario.Size = new Size(306, 28);
            cmbFuncionario.TabIndex = 2;
            // 
            // lbPercentualINSS
            // 
            lbPercentualINSS.AutoSize = true;
            lbPercentualINSS.Location = new Point(23, 208);
            lbPercentualINSS.Name = "lbPercentualINSS";
            lbPercentualINSS.Size = new Size(63, 20);
            lbPercentualINSS.TabIndex = 12;
            lbPercentualINSS.Text = "% INSS:";
            // 
            // tbPercentualINSS
            // 
            tbPercentualINSS.BackColor = SystemColors.InactiveCaption;
            tbPercentualINSS.Enabled = false;
            tbPercentualINSS.Location = new Point(23, 231);
            tbPercentualINSS.Name = "tbPercentualINSS";
            tbPercentualINSS.Size = new Size(109, 27);
            tbPercentualINSS.TabIndex = 0;
            // 
            // lbMesAno
            // 
            lbMesAno.AutoSize = true;
            lbMesAno.Location = new Point(23, 38);
            lbMesAno.Name = "lbMesAno";
            lbMesAno.Size = new Size(78, 20);
            lbMesAno.TabIndex = 9;
            lbMesAno.Text = "Mês/Ano:";
            // 
            // lbSalarioBruto
            // 
            lbSalarioBruto.AutoSize = true;
            lbSalarioBruto.Location = new Point(23, 111);
            lbSalarioBruto.Name = "lbSalarioBruto";
            lbSalarioBruto.Size = new Size(104, 20);
            lbSalarioBruto.TabIndex = 7;
            lbSalarioBruto.Text = "Salario Bruto:";
            // 
            // tbSalarioBruto
            // 
            tbSalarioBruto.BackColor = SystemColors.Window;
            tbSalarioBruto.Location = new Point(23, 134);
            tbSalarioBruto.Name = "tbSalarioBruto";
            tbSalarioBruto.Size = new Size(188, 27);
            tbSalarioBruto.TabIndex = 4;
            tbSalarioBruto.TextChanged += tbSalarioBruto_TextChanged;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(162, 38);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(99, 20);
            lbNome.TabIndex = 3;
            lbNome.Text = "Funcionario: ";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.White;
            btnPesquisar.FlatAppearance.BorderColor = SystemColors.HotTrack;
            btnPesquisar.FlatAppearance.BorderSize = 2;
            btnPesquisar.FlatAppearance.MouseDownBackColor = Color.White;
            btnPesquisar.FlatAppearance.MouseOverBackColor = Color.White;
            btnPesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPesquisar.ForeColor = SystemColors.HotTrack;
            btnPesquisar.Location = new Point(558, 12);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(149, 30);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "Pesquisar ";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(558, 83);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 50);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Location = new Point(324, 83);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(97, 50);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.White;
            btnNovo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovo.Location = new Point(96, 83);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(97, 50);
            btnNovo.TabIndex = 6;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.White;
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(442, 83);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(97, 50);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // frmFolha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(734, 468);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(gbDados);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(752, 515);
            MinimumSize = new Size(752, 515);
            Name = "frmFolha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":: Folha de Pagamento ::";
            Load += frmFolha_Load;
            gbDados.ResumeLayout(false);
            gbDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalvar;
        private GroupBox gbDados;
        private Label lbPercentualINSS;
        private TextBox tbPercentualINSS;
        private Label lbMesAno;
        private Label lbSalarioBruto;
        private TextBox tbSalarioBruto;
        private Label lbNome;
        private Button btnPesquisar;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnNovo;
        private ComboBox cmbFuncionario;
        private MaskedTextBox mtbMesAno;
        private Label lbFgts;
        private TextBox tbFgts;
        private Label lbHorasExtras;
        private TextBox tbHorasExtras;
        private Label lbSalario13;
        private TextBox tbSalario13;
        private Label lbSalarioLiquido;
        private TextBox tbSalarioLiquido;
        private Button btnExcluir;
    }
}