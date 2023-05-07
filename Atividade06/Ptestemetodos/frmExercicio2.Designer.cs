namespace Ptestemetodos
{
    partial class frmExercicio2
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
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnInserir2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(303, 106);
            this.lblPalavra1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(61, 16);
            this.lblPalavra1.TabIndex = 0;
            this.lblPalavra1.Text = "Palavra1";
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(376, 106);
            this.txtPalavra1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(223, 22);
            this.txtPalavra1.TabIndex = 1;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(376, 155);
            this.txtPalavra2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(223, 22);
            this.txtPalavra2.TabIndex = 2;
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(303, 155);
            this.lblPalavra2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(61, 16);
            this.lblPalavra2.TabIndex = 3;
            this.lblPalavra2.Text = "Palavra2";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(195, 239);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(144, 28);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar Iguais";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(365, 239);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(129, 28);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir meio";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // btnInserir2
            // 
            this.btnInserir2.Location = new System.Drawing.Point(522, 239);
            this.btnInserir2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserir2.Name = "btnInserir2";
            this.btnInserir2.Size = new System.Drawing.Size(180, 28);
            this.btnInserir2.TabIndex = 6;
            this.btnInserir2.Text = "Inserir Asteristico";
            this.btnInserir2.UseVisualStyleBackColor = true;
            this.btnInserir2.Click += new System.EventHandler(this.BtnInserir2_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 330);
            this.Controls.Add(this.btnInserir2);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.lblPalavra1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExercicio2";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnInserir2;
    }
}