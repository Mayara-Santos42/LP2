namespace Atividade03
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtxtAltura = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPesoAtual = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPesoIdeal = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSituacao = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.rdbtnMasc = new System.Windows.Forms.RadioButton();
            this.rdbtnFem = new System.Windows.Forms.RadioButton();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtxtAltura
            // 
            this.mtxtAltura.Location = new System.Drawing.Point(234, 60);
            this.mtxtAltura.Name = "mtxtAltura";
            this.mtxtAltura.Size = new System.Drawing.Size(100, 22);
            this.mtxtAltura.TabIndex = 0;
            // 
            // mtxtPesoAtual
            // 
            this.mtxtPesoAtual.Location = new System.Drawing.Point(234, 108);
            this.mtxtPesoAtual.Name = "mtxtPesoAtual";
            this.mtxtPesoAtual.Size = new System.Drawing.Size(100, 22);
            this.mtxtPesoAtual.TabIndex = 1;
            // 
            // mtxtPesoIdeal
            // 
            this.mtxtPesoIdeal.Location = new System.Drawing.Point(234, 170);
            this.mtxtPesoIdeal.Name = "mtxtPesoIdeal";
            this.mtxtPesoIdeal.Size = new System.Drawing.Size(110, 22);
            this.mtxtPesoIdeal.TabIndex = 2;
            // 
            // mtxtSituacao
            // 
            this.mtxtSituacao.Location = new System.Drawing.Point(234, 228);
            this.mtxtSituacao.Name = "mtxtSituacao";
            this.mtxtSituacao.Size = new System.Drawing.Size(110, 22);
            this.mtxtSituacao.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(354, 21);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(126, 365);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(141, 33);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // rdbtnMasc
            // 
            this.rdbtnMasc.AutoSize = true;
            this.rdbtnMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMasc.Location = new System.Drawing.Point(75, 319);
            this.rdbtnMasc.Name = "rdbtnMasc";
            this.rdbtnMasc.Size = new System.Drawing.Size(106, 24);
            this.rdbtnMasc.TabIndex = 6;
            this.rdbtnMasc.TabStop = true;
            this.rdbtnMasc.Text = "Masculino";
            this.rdbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rdbtnFem
            // 
            this.rdbtnFem.AutoSize = true;
            this.rdbtnFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnFem.Location = new System.Drawing.Point(215, 319);
            this.rdbtnFem.Name = "rdbtnFem";
            this.rdbtnFem.Size = new System.Drawing.Size(98, 24);
            this.rdbtnFem.TabIndex = 7;
            this.rdbtnFem.TabStop = true;
            this.rdbtnFem.Text = "Feminino";
            this.rdbtnFem.UseVisualStyleBackColor = true;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(51, 56);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(160, 25);
            this.lblAltura.TabIndex = 8;
            this.lblAltura.Text = "Digite sua Altura:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(51, 104);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(154, 25);
            this.lblPeso.TabIndex = 9;
            this.lblPeso.Text = "Digite seu Peso:";
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.AutoSize = true;
            this.lblPesoIdeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoIdeal.Location = new System.Drawing.Point(69, 167);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(110, 25);
            this.lblPesoIdeal.TabIndex = 10;
            this.lblPesoIdeal.Text = "Peso Ideal:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(69, 224);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(95, 25);
            this.lblSituacao.TabIndex = 11;
            this.lblSituacao.Text = "Situação:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(101, 272);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(176, 25);
            this.lblSexo.TabIndex = 12;
            this.lblSexo.Text = "Qual é o seu sexo:";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(354, 60);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 410);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.rdbtnFem);
            this.Controls.Add(this.rdbtnMasc);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.mtxtSituacao);
            this.Controls.Add(this.mtxtPesoIdeal);
            this.Controls.Add(this.mtxtPesoAtual);
            this.Controls.Add(this.mtxtAltura);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtAltura;
        private System.Windows.Forms.MaskedTextBox mtxtPesoAtual;
        private System.Windows.Forms.MaskedTextBox mtxtPesoIdeal;
        private System.Windows.Forms.MaskedTextBox mtxtSituacao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.RadioButton rdbtnMasc;
        private System.Windows.Forms.RadioButton rdbtnFem;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblPesoIdeal;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Button btnSair;
    }
}

