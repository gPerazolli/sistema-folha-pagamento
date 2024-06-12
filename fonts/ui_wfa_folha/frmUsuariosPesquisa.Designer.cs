namespace ui_wfa_folha
{
    partial class frmUsuariosPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuariosPesquisa));
            gbOpcoes = new GroupBox();
            rbNome = new RadioButton();
            rbId = new RadioButton();
            btnBuscar = new Button();
            tbBusca = new TextBox();
            btnVoltar = new Button();
            btnSelecionar = new Button();
            gridUsuarios = new DataGridView();
            gbOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // gbOpcoes
            // 
            gbOpcoes.BackColor = Color.LightGray;
            gbOpcoes.Controls.Add(rbNome);
            gbOpcoes.Controls.Add(rbId);
            gbOpcoes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbOpcoes.ForeColor = SystemColors.ControlText;
            gbOpcoes.Location = new Point(25, 21);
            gbOpcoes.Name = "gbOpcoes";
            gbOpcoes.Size = new Size(80, 76);
            gbOpcoes.TabIndex = 15;
            gbOpcoes.TabStop = false;
            gbOpcoes.Text = "Opções:";
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
            rbId.CheckedChanged += rbId_CheckedChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(437, 47);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 50);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBusca
            // 
            tbBusca.Location = new Point(127, 59);
            tbBusca.Name = "tbBusca";
            tbBusca.Size = new Size(280, 27);
            tbBusca.TabIndex = 13;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.Location = new Point(437, 416);
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
            btnSelecionar.Location = new Point(301, 416);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(97, 50);
            btnSelecionar.TabIndex = 11;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // gridUsuarios
            // 
            gridUsuarios.AllowUserToAddRows = false;
            gridUsuarios.AllowUserToDeleteRows = false;
            gridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUsuarios.Location = new Point(25, 113);
            gridUsuarios.Name = "gridUsuarios";
            gridUsuarios.ReadOnly = true;
            gridUsuarios.RowHeadersWidth = 51;
            gridUsuarios.RowTemplate.Height = 29;
            gridUsuarios.Size = new Size(509, 284);
            gridUsuarios.TabIndex = 10;
            // 
            // frmUsuariosPesquisa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(556, 486);
            Controls.Add(gbOpcoes);
            Controls.Add(btnBuscar);
            Controls.Add(tbBusca);
            Controls.Add(btnVoltar);
            Controls.Add(btnSelecionar);
            Controls.Add(gridUsuarios);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(574, 533);
            MinimizeBox = false;
            MinimumSize = new Size(574, 533);
            Name = "frmUsuariosPesquisa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":: Pesquisa de Usuarios ::";
            Load += frmUsuariosPesquisa_Load;
            gbOpcoes.ResumeLayout(false);
            gbOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbOpcoes;
        private RadioButton rbNome;
        private RadioButton rbId;
        private Button btnBuscar;
        private TextBox tbBusca;
        private Button btnVoltar;
        private Button btnSelecionar;
        private DataGridView gridUsuarios;
    }
}