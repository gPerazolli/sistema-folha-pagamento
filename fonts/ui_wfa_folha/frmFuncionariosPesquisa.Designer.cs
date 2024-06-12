namespace ui_wfa_folha
{
    partial class frmFuncionariosPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionariosPesquisa));
            gridFuncionarios = new DataGridView();
            btnSelecionar = new Button();
            btnVoltar = new Button();
            tbBusca = new TextBox();
            btnBuscar = new Button();
            rbNome = new RadioButton();
            rbId = new RadioButton();
            gbOpcoes = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)gridFuncionarios).BeginInit();
            gbOpcoes.SuspendLayout();
            SuspendLayout();
            // 
            // gridFuncionarios
            // 
            gridFuncionarios.AllowUserToAddRows = false;
            gridFuncionarios.AllowUserToDeleteRows = false;
            gridFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFuncionarios.Location = new Point(41, 120);
            gridFuncionarios.Name = "gridFuncionarios";
            gridFuncionarios.ReadOnly = true;
            gridFuncionarios.RowHeadersWidth = 51;
            gridFuncionarios.RowTemplate.Height = 29;
            gridFuncionarios.Size = new Size(609, 284);
            gridFuncionarios.TabIndex = 0;
            gridFuncionarios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelecionar.Location = new Point(403, 419);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(97, 50);
            btnSelecionar.TabIndex = 1;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.Location = new Point(553, 419);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(97, 50);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // tbBusca
            // 
            tbBusca.Location = new Point(173, 62);
            tbBusca.Name = "tbBusca";
            tbBusca.Size = new Size(327, 27);
            tbBusca.TabIndex = 4;
            tbBusca.TextChanged += textBox1_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(553, 50);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 50);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += button1_Click;
            // 
            // rbNome
            // 
            rbNome.AutoSize = true;
            rbNome.Location = new Point(6, 26);
            rbNome.Name = "rbNome";
            rbNome.Size = new Size(73, 24);
            rbNome.TabIndex = 6;
            rbNome.TabStop = true;
            rbNome.Text = "Nome";
            rbNome.UseVisualStyleBackColor = true;
            rbNome.CheckedChanged += rbNome_CheckedChanged;
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
            rbId.CheckedChanged += rbID_CheckedChanged;
            // 
            // gbOpcoes
            // 
            gbOpcoes.BackColor = Color.LightGray;
            gbOpcoes.Controls.Add(rbNome);
            gbOpcoes.Controls.Add(rbId);
            gbOpcoes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbOpcoes.ForeColor = SystemColors.ControlText;
            gbOpcoes.Location = new Point(41, 24);
            gbOpcoes.Name = "gbOpcoes";
            gbOpcoes.Size = new Size(80, 76);
            gbOpcoes.TabIndex = 9;
            gbOpcoes.TabStop = false;
            gbOpcoes.Text = "Opções:";
            // 
            // frmFuncionariosPesquisa
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
            Controls.Add(gridFuncionarios);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(730, 533);
            MinimizeBox = false;
            MinimumSize = new Size(730, 533);
            Name = "frmFuncionariosPesquisa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":: Pesquisa de Funcionarios ::";
            Load += frmFuncionariosPesquisa_Load;
            ((System.ComponentModel.ISupportInitialize)gridFuncionarios).EndInit();
            gbOpcoes.ResumeLayout(false);
            gbOpcoes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridFuncionarios;
        private Button btnSelecionar;
        private Button btnVoltar;
        private TextBox tbBusca;
        private Button btnBuscar;
        private RadioButton rbNome;
        private RadioButton rbId;
        private GroupBox gbOpcoes;
    }
}