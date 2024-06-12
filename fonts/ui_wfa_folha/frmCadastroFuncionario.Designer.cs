namespace ui_wfa_folha
{
    partial class frmCadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFuncionario));
            btnNovo = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            gbDados = new GroupBox();
            mtbCpf = new MaskedTextBox();
            mtbCtps = new MaskedTextBox();
            cbSituacao = new CheckBox();
            lbCtps = new Label();
            dtAdmissao = new DateTimePicker();
            lbAdmissao = new Label();
            lbCargo = new Label();
            tbCargo = new TextBox();
            lbCpf = new Label();
            lbNome = new Label();
            tbNome = new TextBox();
            tbId = new TextBox();
            lbId = new Label();
            btnSalvar = new Button();
            btnPesquisar = new Button();
            gbDados.SuspendLayout();
            SuspendLayout();
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovo.Location = new Point(139, 69);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(97, 50);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ControlLightLight;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Location = new Point(418, 69);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(97, 50);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLightLight;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(554, 69);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 50);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // gbDados
            // 
            gbDados.BackColor = Color.LightGray;
            gbDados.Controls.Add(mtbCpf);
            gbDados.Controls.Add(mtbCtps);
            gbDados.Controls.Add(cbSituacao);
            gbDados.Controls.Add(lbCtps);
            gbDados.Controls.Add(dtAdmissao);
            gbDados.Controls.Add(lbAdmissao);
            gbDados.Controls.Add(lbCargo);
            gbDados.Controls.Add(tbCargo);
            gbDados.Controls.Add(lbCpf);
            gbDados.Controls.Add(lbNome);
            gbDados.Controls.Add(tbNome);
            gbDados.Controls.Add(tbId);
            gbDados.Controls.Add(lbId);
            gbDados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbDados.Location = new Point(28, 136);
            gbDados.Name = "gbDados";
            gbDados.Size = new Size(739, 276);
            gbDados.TabIndex = 4;
            gbDados.TabStop = false;
            gbDados.Text = "Dados";
            // 
            // mtbCpf
            // 
            mtbCpf.BackColor = SystemColors.Window;
            mtbCpf.Culture = new System.Globalization.CultureInfo("en-US");
            mtbCpf.Location = new Point(498, 61);
            mtbCpf.Mask = "###.###.###-##";
            mtbCpf.Name = "mtbCpf";
            mtbCpf.Size = new Size(171, 27);
            mtbCpf.TabIndex = 2;
            // 
            // mtbCtps
            // 
            mtbCtps.BackColor = SystemColors.Window;
            mtbCtps.Location = new Point(23, 210);
            mtbCtps.Mask = "#######/####";
            mtbCtps.Name = "mtbCtps";
            mtbCtps.Size = new Size(147, 27);
            mtbCtps.TabIndex = 5;
            // 
            // cbSituacao
            // 
            cbSituacao.AutoSize = true;
            cbSituacao.BackColor = Color.Transparent;
            cbSituacao.Checked = true;
            cbSituacao.CheckState = CheckState.Checked;
            cbSituacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbSituacao.Location = new Point(579, 210);
            cbSituacao.Name = "cbSituacao";
            cbSituacao.Size = new Size(90, 24);
            cbSituacao.TabIndex = 13;
            cbSituacao.Text = "Situação";
            cbSituacao.UseVisualStyleBackColor = false;
            cbSituacao.Visible = false;
            cbSituacao.CheckedChanged += cbSituacao_CheckedChanged;
            // 
            // lbCtps
            // 
            lbCtps.AutoSize = true;
            lbCtps.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCtps.Location = new Point(23, 185);
            lbCtps.Name = "lbCtps";
            lbCtps.Size = new Size(48, 20);
            lbCtps.TabIndex = 12;
            lbCtps.Text = "CTPS:";
            // 
            // dtAdmissao
            // 
            dtAdmissao.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtAdmissao.Format = DateTimePickerFormat.Short;
            dtAdmissao.Location = new Point(496, 136);
            dtAdmissao.Name = "dtAdmissao";
            dtAdmissao.Size = new Size(171, 27);
            dtAdmissao.TabIndex = 4;
            dtAdmissao.Value = new DateTime(2023, 10, 19, 0, 0, 0, 0);
            // 
            // lbAdmissao
            // 
            lbAdmissao.AutoSize = true;
            lbAdmissao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbAdmissao.Location = new Point(496, 113);
            lbAdmissao.Name = "lbAdmissao";
            lbAdmissao.Size = new Size(140, 20);
            lbAdmissao.TabIndex = 9;
            lbAdmissao.Text = "Data de Admissão:";
            // 
            // lbCargo
            // 
            lbCargo.AutoSize = true;
            lbCargo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCargo.Location = new Point(23, 113);
            lbCargo.Name = "lbCargo";
            lbCargo.Size = new Size(54, 20);
            lbCargo.TabIndex = 7;
            lbCargo.Text = "Cargo:";
            // 
            // tbCargo
            // 
            tbCargo.Location = new Point(23, 136);
            tbCargo.Name = "tbCargo";
            tbCargo.Size = new Size(441, 27);
            tbCargo.TabIndex = 3;
            // 
            // lbCpf
            // 
            lbCpf.AutoSize = true;
            lbCpf.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCpf.Location = new Point(496, 38);
            lbCpf.Name = "lbCpf";
            lbCpf.Size = new Size(39, 20);
            lbCpf.TabIndex = 5;
            lbCpf.Text = "CPF:";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbNome.Location = new Point(115, 38);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(164, 20);
            lbNome.TabIndex = 3;
            lbNome.Text = "Nome do Funcionario:";
            // 
            // tbNome
            // 
            tbNome.BackColor = SystemColors.Window;
            tbNome.Location = new Point(115, 61);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(349, 27);
            tbNome.TabIndex = 1;
            // 
            // tbId
            // 
            tbId.BackColor = SystemColors.InactiveCaption;
            tbId.Enabled = false;
            tbId.Location = new Point(23, 61);
            tbId.Name = "tbId";
            tbId.Size = new Size(65, 27);
            tbId.TabIndex = 0;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbId.Location = new Point(23, 38);
            lbId.Name = "lbId";
            lbId.Size = new Size(29, 20);
            lbId.TabIndex = 0;
            lbId.Text = "ID:";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(277, 69);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(97, 50);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
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
            btnPesquisar.Location = new Point(625, 12);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(142, 30);
            btnPesquisar.TabIndex = 10;
            btnPesquisar.Text = "Pesquisar ";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click_1;
            // 
            // frmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPesquisar);
            Controls.Add(btnSalvar);
            Controls.Add(gbDados);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(818, 497);
            Name = "frmCadastroFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":: Cadastro de Funcionarios ::";
            Load += frmCadastroFuncionario_Load;
            gbDados.ResumeLayout(false);
            gbDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNovo;
        private Button btnEditar;
        private Button btnCancelar;
        private GroupBox gbDados;
        private Label lbNome;
        private TextBox tbNome;
        private TextBox tbId;
        private Label lbId;
        private DateTimePicker dtAdmissao;
        private Label lbAdmissao;
        private Label lbCargo;
        private TextBox tbCargo;
        private Label lbCpf;
        private Label lbCtps;
        private CheckBox cbSituacao;
        private Button btnSalvar;
        private Button btnPesquisar;
        private MaskedTextBox mtbCtps;
        private MaskedTextBox mtbCpf;
    }
}