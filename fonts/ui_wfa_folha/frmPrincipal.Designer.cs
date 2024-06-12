namespace ui_wfa_folha
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            funcionariosToolStripMenuItem = new ToolStripMenuItem();
            folhaToolStripMenuItem = new ToolStripMenuItem();
            relatoriosToolStripMenuItem = new ToolStripMenuItem();
            folhaDosFuncionariosToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem1 = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            statusVersao = new ToolStripStatusLabel();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnLogOff = new Button();
            btnSair = new Button();
            lbData = new Label();
            lbBemVindo = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, folhaToolStripMenuItem, relatoriosToolStripMenuItem, usuariosToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1017, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { funcionariosToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(106, 24);
            cadastroToolStripMenuItem.Text = "Funcionarios";
            // 
            // funcionariosToolStripMenuItem
            // 
            funcionariosToolStripMenuItem.BackColor = Color.Gainsboro;
            funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            funcionariosToolStripMenuItem.Size = new Size(151, 26);
            funcionariosToolStripMenuItem.Text = "Cadastro";
            funcionariosToolStripMenuItem.Click += funcionariosToolStripMenuItem_Click;
            // 
            // folhaToolStripMenuItem
            // 
            folhaToolStripMenuItem.Name = "folhaToolStripMenuItem";
            folhaToolStripMenuItem.Size = new Size(59, 24);
            folhaToolStripMenuItem.Text = "Folha";
            folhaToolStripMenuItem.Click += folhaToolStripMenuItem_Click;
            // 
            // relatoriosToolStripMenuItem
            // 
            relatoriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { folhaDosFuncionariosToolStripMenuItem });
            relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            relatoriosToolStripMenuItem.Size = new Size(90, 24);
            relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // folhaDosFuncionariosToolStripMenuItem
            // 
            folhaDosFuncionariosToolStripMenuItem.BackColor = Color.Gainsboro;
            folhaDosFuncionariosToolStripMenuItem.Name = "folhaDosFuncionariosToolStripMenuItem";
            folhaDosFuncionariosToolStripMenuItem.Size = new Size(243, 26);
            folhaDosFuncionariosToolStripMenuItem.Text = "Folha dos Funcionarios";
            folhaDosFuncionariosToolStripMenuItem.Click += folhaDosFuncionariosToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem1 });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(79, 24);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // cadastroToolStripMenuItem1
            // 
            cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            cadastroToolStripMenuItem1.Size = new Size(151, 26);
            cadastroToolStripMenuItem1.Text = "Cadastro";
            cadastroToolStripMenuItem1.Click += cadastroToolStripMenuItem1_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(62, 24);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.BackColor = Color.Gainsboro;
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(131, 26);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.White;
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusVersao });
            statusStrip.Location = new Point(0, 439);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1017, 26);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // statusVersao
            // 
            statusVersao.Name = "statusVersao";
            statusVersao.Size = new Size(87, 20);
            statusVersao.Text = "Versão 1.0.1";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(lbData);
            groupBox1.Controls.Add(lbBemVindo);
            groupBox1.Location = new Point(0, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2000, 168);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(btnLogOff);
            flowLayoutPanel1.Controls.Add(btnSair);
            flowLayoutPanel1.Location = new Point(1710, 28);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(198, 100);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnLogOff
            // 
            btnLogOff.Image = Properties.Resources.logOff;
            btnLogOff.Location = new Point(3, 3);
            btnLogOff.Name = "btnLogOff";
            btnLogOff.Size = new Size(93, 97);
            btnLogOff.TabIndex = 0;
            btnLogOff.Text = "LogOff";
            btnLogOff.TextAlign = ContentAlignment.BottomCenter;
            btnLogOff.UseVisualStyleBackColor = true;
            btnLogOff.Click += btnLogOff_Click;
            // 
            // btnSair
            // 
            btnSair.Image = Properties.Resources.logOut;
            btnSair.Location = new Point(102, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(93, 97);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.BottomCenter;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbData.ForeColor = SystemColors.ControlLightLight;
            lbData.Location = new Point(23, 82);
            lbData.Name = "lbData";
            lbData.Size = new Size(101, 46);
            lbData.TabIndex = 1;
            lbData.Text = "DATA";
            // 
            // lbBemVindo
            // 
            lbBemVindo.AutoSize = true;
            lbBemVindo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbBemVindo.ForeColor = SystemColors.ControlLightLight;
            lbBemVindo.Location = new Point(26, 23);
            lbBemVindo.Name = "lbBemVindo";
            lbBemVindo.Size = new Size(201, 46);
            lbBemVindo.TabIndex = 0;
            lbBemVindo.Text = "BEM VINDO";
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(1250, 723);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(703, 242);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(294, 94);
            button1.Name = "button1";
            button1.Size = new Size(308, 55);
            button1.TabIndex = 1;
            button1.Text = "ACESSAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(294, 14);
            label1.Name = "label1";
            label1.Size = new Size(322, 54);
            label1.TabIndex = 0;
            label1.Text = "Suporte Técnico";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1017, 465);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = ":: Sistema - Folha de Pagamento ::";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem funcionariosToolStripMenuItem;
        private ToolStripMenuItem folhaToolStripMenuItem;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusVersao;
        private GroupBox groupBox1;
        private Label lbData;
        private Label lbBemVindo;
        private System.Windows.Forms.Timer timer1;
        private Button btnSair;
        private Button btnLogOff;
        private FlowLayoutPanel flowLayoutPanel1;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
        private ToolStripMenuItem folhaDosFuncionariosToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem1;
        private GroupBox groupBox2;
        private Label label1;
        private Button button1;
    }
}