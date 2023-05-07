namespace ProjSalário
{
    partial class ProjetoSalario
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskbxSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.nmrcFilhos = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnM = new System.Windows.Forms.RadioButton();
            this.rbtnF = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblAliINSS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.txtDescIrrf = new System.Windows.Forms.TextBox();
            this.txtDescInss = new System.Windows.Forms.TextBox();
            this.txtSalLiq = new System.Windows.Forms.TextBox();
            this.txtSalFal = new System.Windows.Forms.TextBox();
            this.txtAliqIrrf = new System.Windows.Forms.TextBox();
            this.txtAliqInss = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcFilhos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(317, 145);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(148, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome completo";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(503, 145);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(132, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            this.txtNome.Validated += new System.EventHandler(this.TxtNome_Validated);
            // 
            // mskbxSalBruto
            // 
            this.mskbxSalBruto.Location = new System.Drawing.Point(503, 197);
            this.mskbxSalBruto.Margin = new System.Windows.Forms.Padding(4);
            this.mskbxSalBruto.Mask = "99990.00";
            this.mskbxSalBruto.Name = "mskbxSalBruto";
            this.mskbxSalBruto.Size = new System.Drawing.Size(132, 22);
            this.mskbxSalBruto.TabIndex = 2;
            this.mskbxSalBruto.Validated += new System.EventHandler(this.MskbxSalBruto_Validated);
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal.Location = new System.Drawing.Point(317, 197);
            this.lblSal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(124, 25);
            this.lblSal.TabIndex = 3;
            this.lblSal.Text = "Salário Bruto";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFilhos.Location = new System.Drawing.Point(317, 251);
            this.lblNumFilhos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(158, 25);
            this.lblNumFilhos.TabIndex = 4;
            this.lblNumFilhos.Text = "Número de filhos";
            // 
            // nmrcFilhos
            // 
            this.nmrcFilhos.Location = new System.Drawing.Point(503, 250);
            this.nmrcFilhos.Margin = new System.Windows.Forms.Padding(4);
            this.nmrcFilhos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmrcFilhos.Name = "nmrcFilhos";
            this.nmrcFilhos.Size = new System.Drawing.Size(160, 22);
            this.nmrcFilhos.TabIndex = 5;
            this.nmrcFilhos.Validated += new System.EventHandler(this.NmrcFilhos_Validated);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnM);
            this.groupBox1.Controls.Add(this.rbtnF);
            this.groupBox1.Location = new System.Drawing.Point(935, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 123);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rdbtnM
            // 
            this.rdbtnM.AutoSize = true;
            this.rdbtnM.Checked = true;
            this.rdbtnM.Location = new System.Drawing.Point(56, 52);
            this.rdbtnM.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnM.Name = "rdbtnM";
            this.rdbtnM.Size = new System.Drawing.Size(39, 20);
            this.rdbtnM.TabIndex = 1;
            this.rdbtnM.TabStop = true;
            this.rdbtnM.Text = "M";
            this.rdbtnM.UseVisualStyleBackColor = true;
            this.rdbtnM.Click += new System.EventHandler(this.RdbtnM_Click);
            // 
            // rbtnF
            // 
            this.rbtnF.AutoSize = true;
            this.rbtnF.Location = new System.Drawing.Point(147, 52);
            this.rbtnF.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnF.Name = "rbtnF";
            this.rbtnF.Size = new System.Drawing.Size(36, 20);
            this.rbtnF.TabIndex = 0;
            this.rbtnF.Text = "F";
            this.rbtnF.UseVisualStyleBackColor = true;
            this.rbtnF.Click += new System.EventHandler(this.RbtnF_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckbxCasado);
            this.panel1.Location = new System.Drawing.Point(935, 289);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 123);
            this.panel1.TabIndex = 7;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(56, 52);
            this.ckbxCasado.Margin = new System.Windows.Forms.Padding(4);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(77, 20);
            this.ckbxCasado.TabIndex = 0;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            this.ckbxCasado.Click += new System.EventHandler(this.CkbxCasado_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(475, 336);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(213, 28);
            this.btnVerificar.TabIndex = 8;
            this.btnVerificar.Text = "Verificar Desconto";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // lblAliINSS
            // 
            this.lblAliINSS.AutoSize = true;
            this.lblAliINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliINSS.Location = new System.Drawing.Point(317, 466);
            this.lblAliINSS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAliINSS.Name = "lblAliINSS";
            this.lblAliINSS.Size = new System.Drawing.Size(135, 25);
            this.lblAliINSS.TabIndex = 9;
            this.lblAliINSS.Text = "Aliquota INSS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 517);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Aliquota IRRF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 569);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Salário Família";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 614);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Salário Líquido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(725, 466);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Desconto INSS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(725, 517);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Desconto IRRF";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(319, 396);
            this.lblDados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(62, 16);
            this.lblDados.TabIndex = 21;
            this.lblDados.Text = "lblDados";
            // 
            // txtDescIrrf
            // 
            this.txtDescIrrf.Enabled = false;
            this.txtDescIrrf.Location = new System.Drawing.Point(893, 517);
            this.txtDescIrrf.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescIrrf.Name = "txtDescIrrf";
            this.txtDescIrrf.Size = new System.Drawing.Size(132, 22);
            this.txtDescIrrf.TabIndex = 20;
            // 
            // txtDescInss
            // 
            this.txtDescInss.Enabled = false;
            this.txtDescInss.Location = new System.Drawing.Point(893, 469);
            this.txtDescInss.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescInss.Name = "txtDescInss";
            this.txtDescInss.Size = new System.Drawing.Size(132, 22);
            this.txtDescInss.TabIndex = 19;
            // 
            // txtSalLiq
            // 
            this.txtSalLiq.Enabled = false;
            this.txtSalLiq.Location = new System.Drawing.Point(503, 617);
            this.txtSalLiq.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalLiq.Name = "txtSalLiq";
            this.txtSalLiq.Size = new System.Drawing.Size(132, 22);
            this.txtSalLiq.TabIndex = 18;
            // 
            // txtSalFal
            // 
            this.txtSalFal.Enabled = false;
            this.txtSalFal.Location = new System.Drawing.Point(503, 571);
            this.txtSalFal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalFal.Name = "txtSalFal";
            this.txtSalFal.Size = new System.Drawing.Size(132, 22);
            this.txtSalFal.TabIndex = 17;
            // 
            // txtAliqIrrf
            // 
            this.txtAliqIrrf.Enabled = false;
            this.txtAliqIrrf.Location = new System.Drawing.Point(503, 517);
            this.txtAliqIrrf.Margin = new System.Windows.Forms.Padding(4);
            this.txtAliqIrrf.Name = "txtAliqIrrf";
            this.txtAliqIrrf.Size = new System.Drawing.Size(132, 22);
            this.txtAliqIrrf.TabIndex = 16;
            // 
            // txtAliqInss
            // 
            this.txtAliqInss.Enabled = false;
            this.txtAliqInss.Location = new System.Drawing.Point(503, 466);
            this.txtAliqInss.Margin = new System.Windows.Forms.Padding(4);
            this.txtAliqInss.Name = "txtAliqInss";
            this.txtAliqInss.Size = new System.Drawing.Size(132, 22);
            this.txtAliqInss.TabIndex = 12;
            // 
            // ProjetoSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 772);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.txtDescIrrf);
            this.Controls.Add(this.txtDescInss);
            this.Controls.Add(this.txtSalLiq);
            this.Controls.Add(this.txtSalFal);
            this.Controls.Add(this.txtAliqIrrf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAliqInss);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAliINSS);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nmrcFilhos);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.mskbxSalBruto);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProjetoSalario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcFilhos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskbxSalBruto;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.NumericUpDown nmrcFilhos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnM;
        private System.Windows.Forms.RadioButton rbtnF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblAliINSS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.TextBox txtDescIrrf;
        private System.Windows.Forms.TextBox txtDescInss;
        private System.Windows.Forms.TextBox txtSalLiq;
        private System.Windows.Forms.TextBox txtSalFal;
        private System.Windows.Forms.TextBox txtAliqIrrf;
        private System.Windows.Forms.TextBox txtAliqInss;
    }
}

