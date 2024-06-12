namespace ui_wfa_folha
{
    partial class frmRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorios));
            cmbFuncionario = new ComboBox();
            lbNome = new Label();
            label1 = new Label();
            btnGerar = new Button();
            listRelatorio = new ListBox();
            dateFuncionario = new DateTimePicker();
            lbData = new Label();
            SuspendLayout();
            // 
            // cmbFuncionario
            // 
            cmbFuncionario.BackColor = SystemColors.Window;
            cmbFuncionario.FormattingEnabled = true;
            cmbFuncionario.Location = new Point(26, 116);
            cmbFuncionario.Name = "cmbFuncionario";
            cmbFuncionario.Size = new Size(306, 28);
            cmbFuncionario.TabIndex = 4;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbNome.Location = new Point(26, 93);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(193, 20);
            lbNome.TabIndex = 5;
            lbNome.Text = "Selecione um funcionário: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(227, 25);
            label1.Name = "label1";
            label1.Size = new Size(128, 31);
            label1.TabIndex = 6;
            label1.Text = "Relatórios ";
            label1.Click += label1_Click;
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(408, 103);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(107, 52);
            btnGerar.TabIndex = 7;
            btnGerar.Text = "Visualizar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // listRelatorio
            // 
            listRelatorio.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            listRelatorio.FormattingEnabled = true;
            listRelatorio.HorizontalScrollbar = true;
            listRelatorio.ItemHeight = 26;
            listRelatorio.Location = new Point(26, 247);
            listRelatorio.MaximumSize = new Size(506, 344);
            listRelatorio.MinimumSize = new Size(506, 344);
            listRelatorio.Name = "listRelatorio";
            listRelatorio.Size = new Size(506, 342);
            listRelatorio.TabIndex = 8;
            listRelatorio.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // dateFuncionario
            // 
            dateFuncionario.Format = DateTimePickerFormat.Custom;
            dateFuncionario.Location = new Point(26, 184);
            dateFuncionario.Name = "dateFuncionario";
            dateFuncionario.Size = new Size(129, 27);
            dateFuncionario.TabIndex = 9;
            dateFuncionario.Value = new DateTime(2023, 11, 1, 0, 0, 0, 0);
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbData.Location = new Point(26, 161);
            lbData.Name = "lbData";
            lbData.Size = new Size(129, 20);
            lbData.TabIndex = 10;
            lbData.Text = "Selecione a data: ";
            // 
            // frmRelatorios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(560, 605);
            Controls.Add(lbData);
            Controls.Add(dateFuncionario);
            Controls.Add(listRelatorio);
            Controls.Add(btnGerar);
            Controls.Add(label1);
            Controls.Add(cmbFuncionario);
            Controls.Add(lbNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(578, 652);
            MinimumSize = new Size(578, 652);
            Name = "frmRelatorios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":: Relatórios Folha de Pagamento ::";
            Load += frmRelatorios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFuncionario;
        private Label lbNome;
        private Label label1;
        private Button btnGerar;
        private ListBox listRelatorio;
        private DateTimePicker dateFuncionario;
        private Label lbData;
    }
}