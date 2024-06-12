namespace ui_wfa_folha
{
    partial class frmFolhaPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaPesquisa));
            gbOpcoes = new GroupBox();
            rbMesAno = new RadioButton();
            rbId = new RadioButton();
            btnBuscar = new Button();
            tbBusca = new TextBox();
            btnVoltar = new Button();
            btnSelecionar = new Button();
            gridFolha = new DataGridView();
            gbOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridFolha).BeginInit();
            SuspendLayout();
            // 
            // gbOpcoes
            // 
            gbOpcoes.BackColor = Color.LightGray;
            gbOpcoes.Controls.Add(rbMesAno);
            gbOpcoes.Controls.Add(rbId);
            gbOpcoes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbOpcoes.ForeColor = SystemColors.ControlText;
            gbOpcoes.Location = new Point(52, 21);
            gbOpcoes.Name = "gbOpcoes";
            gbOpcoes.Size = new Size(97, 76);
            gbOpcoes.TabIndex = 15;
            gbOpcoes.TabStop = false;
            gbOpcoes.Text = "Opções:";
            // 
            // rbMesAno
            // 
            rbMesAno.AutoSize = true;
            rbMesAno.Location = new Point(6, 26);
            rbMesAno.Name = "rbMesAno";
            rbMesAno.Size = new Size(95, 24);
            rbMesAno.TabIndex = 6;
            rbMesAno.TabStop = true;
            rbMesAno.Text = "Mês/Ano";
            rbMesAno.UseVisualStyleBackColor = true;
            rbMesAno.CheckedChanged += rbMesAno_CheckedChanged;
            // 
            // rbId
            // 
            rbId.AutoSize = true;
            rbId.Location = new Point(6, 50);
            rbId.Name = "rbId";
            rbId.Size = new Size(46, 24);
            rbId.TabIndex = 7;
            rbId.TabStop = true;
            rbId.Text = "ID";
            rbId.UseVisualStyleBackColor = true;
            rbId.CheckedChanged += rbId_CheckedChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(564, 47);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 50);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBusca
            // 
            tbBusca.Location = new Point(184, 59);
            tbBusca.Name = "tbBusca";
            tbBusca.Size = new Size(327, 27);
            tbBusca.TabIndex = 13;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.Location = new Point(564, 416);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(97, 50);
            btnVoltar.TabIndex = 12;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelecionar.Location = new Point(414, 416);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(97, 50);
            btnSelecionar.TabIndex = 11;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // gridFolha
            // 
            gridFolha.AllowUserToAddRows = false;
            gridFolha.AllowUserToDeleteRows = false;
            gridFolha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFolha.Location = new Point(52, 117);
            gridFolha.Name = "gridFolha";
            gridFolha.ReadOnly = true;
            gridFolha.RowHeadersWidth = 51;
            gridFolha.RowTemplate.Height = 29;
            gridFolha.Size = new Size(609, 284);
            gridFolha.TabIndex = 10;
            // 
            // frmFolhaPesquisa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(712, 486);
            Controls.Add(gbOpcoes);
            Controls.Add(btnBuscar);
            Controls.Add(tbBusca);
            Controls.Add(btnVoltar);
            Controls.Add(btnSelecionar);
            Controls.Add(gridFolha);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(730, 533);
            MinimizeBox = false;
            MinimumSize = new Size(730, 533);
            Name = "frmFolhaPesquisa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":: Pesquisa da Folha de Pagamento ::";
            Load += frmFolhaPesquisa_Load;
            gbOpcoes.ResumeLayout(false);
            gbOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridFolha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbOpcoes;
        private RadioButton rbMesAno;
        private RadioButton rbId;
        private Button btnBuscar;
        private TextBox tbBusca;
        private Button btnVoltar;
        private Button btnSelecionar;
        private DataGridView gridFolha;
    }
}