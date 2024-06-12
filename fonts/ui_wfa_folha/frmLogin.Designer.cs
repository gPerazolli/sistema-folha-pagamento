namespace ui_wfa_folha
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lbLogin = new Label();
            btnEntrar = new Button();
            tbLogin = new TextBox();
            tbSenha = new TextBox();
            lbSenha = new Label();
            btnSair = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(243, 71);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(49, 20);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Login:";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(399, 91);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(94, 44);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // tbLogin
            // 
            tbLogin.BackColor = SystemColors.Window;
            tbLogin.Location = new Point(245, 100);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(125, 27);
            tbLogin.TabIndex = 1;
            // 
            // tbSenha
            // 
            tbSenha.Location = new Point(245, 182);
            tbSenha.Name = "tbSenha";
            tbSenha.PasswordChar = '*';
            tbSenha.Size = new Size(125, 27);
            tbSenha.TabIndex = 2;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(243, 159);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(52, 20);
            lbSenha.TabIndex = 3;
            lbSenha.Text = "Senha:";
            // 
            // btnSair
            // 
            btnSair.Location = new Point(399, 173);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 44);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(223, 20);
            label1.Name = "label1";
            label1.Size = new Size(87, 31);
            label1.TabIndex = 7;
            label1.Text = "Acesso";
            // 
            // frmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(544, 259);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnSair);
            Controls.Add(tbSenha);
            Controls.Add(lbSenha);
            Controls.Add(tbLogin);
            Controls.Add(btnEntrar);
            Controls.Add(lbLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(562, 306);
            MinimizeBox = false;
            MinimumSize = new Size(562, 306);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":: Controle de Acesso ::";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLogin;
        private Button btnEntrar;
        private TextBox tbLogin;
        private TextBox tbSenha;
        private Label lbSenha;
        private Button btnSair;
        private PictureBox pictureBox1;
        private Label label1;
    }
}