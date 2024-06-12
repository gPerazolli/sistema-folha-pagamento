namespace ui_wfa_folha
{
    partial class frmCadastroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuarios));
            btnExcluir = new Button();
            btnSalvar = new Button();
            gbDados = new GroupBox();
            lbLogin = new Label();
            tbLogin = new TextBox();
            lbNome = new Label();
            tbNome = new TextBox();
            lbConfirmarSenha = new Label();
            tbConfirmarSenha = new TextBox();
            lbSenha = new Label();
            tbSenha = new TextBox();
            lbId = new Label();
            tbId = new TextBox();
            btnPesquisar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnNovo = new Button();
            gbDados.SuspendLayout();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.White;
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(380, 83);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(97, 50);
            btnExcluir.TabIndex = 19;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.White;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(148, 83);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(97, 50);
            btnSalvar.TabIndex = 18;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // gbDados
            // 
            gbDados.BackColor = Color.LightGray;
            gbDados.Controls.Add(lbLogin);
            gbDados.Controls.Add(tbLogin);
            gbDados.Controls.Add(lbNome);
            gbDados.Controls.Add(tbNome);
            gbDados.Controls.Add(lbConfirmarSenha);
            gbDados.Controls.Add(tbConfirmarSenha);
            gbDados.Controls.Add(lbSenha);
            gbDados.Controls.Add(tbSenha);
            gbDados.Controls.Add(lbId);
            gbDados.Controls.Add(tbId);
            gbDados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbDados.Location = new Point(22, 151);
            gbDados.Name = "gbDados";
            gbDados.Size = new Size(582, 305);
            gbDados.TabIndex = 17;
            gbDados.TabStop = false;
            gbDados.Text = "Dados";
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(339, 112);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(52, 20);
            lbLogin.TabIndex = 22;
            lbLogin.Text = "Login:";
            // 
            // tbLogin
            // 
            tbLogin.BackColor = SystemColors.Window;
            tbLogin.Location = new Point(339, 135);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(188, 27);
            tbLogin.TabIndex = 2;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(23, 112);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(56, 20);
            lbNome.TabIndex = 20;
            lbNome.Text = "Nome:";
            // 
            // tbNome
            // 
            tbNome.BackColor = SystemColors.Window;
            tbNome.Location = new Point(23, 135);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(243, 27);
            tbNome.TabIndex = 1;
            // 
            // lbConfirmarSenha
            // 
            lbConfirmarSenha.AutoSize = true;
            lbConfirmarSenha.Location = new Point(316, 208);
            lbConfirmarSenha.Name = "lbConfirmarSenha";
            lbConfirmarSenha.Size = new Size(130, 20);
            lbConfirmarSenha.TabIndex = 16;
            lbConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // tbConfirmarSenha
            // 
            tbConfirmarSenha.BackColor = SystemColors.Window;
            tbConfirmarSenha.Location = new Point(316, 231);
            tbConfirmarSenha.Name = "tbConfirmarSenha";
            tbConfirmarSenha.Size = new Size(167, 27);
            tbConfirmarSenha.TabIndex = 4;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(77, 208);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(55, 20);
            lbSenha.TabIndex = 12;
            lbSenha.Text = "Senha:";
            // 
            // tbSenha
            // 
            tbSenha.BackColor = SystemColors.Window;
            tbSenha.Location = new Point(77, 231);
            tbSenha.Name = "tbSenha";
            tbSenha.Size = new Size(162, 27);
            tbSenha.TabIndex = 3;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(23, 38);
            lbId.Name = "lbId";
            lbId.Size = new Size(29, 20);
            lbId.TabIndex = 9;
            lbId.Text = "ID:";
            // 
            // tbId
            // 
            tbId.BackColor = SystemColors.InactiveCaption;
            tbId.Enabled = false;
            tbId.Location = new Point(23, 62);
            tbId.Name = "tbId";
            tbId.Size = new Size(63, 27);
            tbId.TabIndex = 0;
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
            btnPesquisar.Location = new Point(462, 12);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(142, 30);
            btnPesquisar.TabIndex = 16;
            btnPesquisar.Text = "Pesquisar ";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(496, 83);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 50);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Location = new Point(262, 83);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(97, 50);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.White;
            btnNovo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovo.Location = new Point(34, 83);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(97, 50);
            btnNovo.TabIndex = 13;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // frmCadastroUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(631, 468);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(gbDados);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(649, 515);
            MinimumSize = new Size(649, 515);
            Name = "frmCadastroUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":: Cadastro de Usuarios ::";
            Load += frmCadastroUsuarios_Load;
            gbDados.ResumeLayout(false);
            gbDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExcluir;
        private Button btnSalvar;
        private GroupBox gbDados;
        private Label lbLogin;
        private TextBox tbLogin;
        private Label lbNome;
        private TextBox tbNome;
        private Label lbConfirmarSenha;
        private TextBox tbConfirmarSenha;
        private Label lbSenha;
        private TextBox tbSenha;
        private Label lbId;
        private TextBox tbId;
        private Button btnPesquisar;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnNovo;
    }
}