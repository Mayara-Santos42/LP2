namespace Ptestemetodos
{
    partial class frmExercicio3
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
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.btnRemova1 = new System.Windows.Forms.Button();
            this.btnRemova2 = new System.Windows.Forms.Button();
            this.btnInverte = new System.Windows.Forms.Button();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(289, 90);
            this.txtPalavra2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(132, 22);
            this.txtPalavra2.TabIndex = 0;
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(93, 90);
            this.txtPalavra1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(132, 22);
            this.txtPalavra1.TabIndex = 1;
            this.txtPalavra1.TextChanged += new System.EventHandler(this.txtPalavra1_TextChanged);
            // 
            // btnRemova1
            // 
            this.btnRemova1.Location = new System.Drawing.Point(125, 143);
            this.btnRemova1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemova1.Name = "btnRemova1";
            this.btnRemova1.Size = new System.Drawing.Size(100, 28);
            this.btnRemova1.TabIndex = 2;
            this.btnRemova1.Text = "Remover 1";
            this.btnRemova1.UseVisualStyleBackColor = true;
            this.btnRemova1.Click += new System.EventHandler(this.BtnRemova1_Click);
            // 
            // btnRemova2
            // 
            this.btnRemova2.Location = new System.Drawing.Point(270, 143);
            this.btnRemova2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemova2.Name = "btnRemova2";
            this.btnRemova2.Size = new System.Drawing.Size(100, 28);
            this.btnRemova2.TabIndex = 3;
            this.btnRemova2.Text = "Remover 2";
            this.btnRemova2.UseVisualStyleBackColor = true;
            this.btnRemova2.Click += new System.EventHandler(this.BtnRemova2_Click);
            // 
            // btnInverte
            // 
            this.btnInverte.Location = new System.Drawing.Point(190, 212);
            this.btnInverte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInverte.Name = "btnInverte";
            this.btnInverte.Size = new System.Drawing.Size(100, 28);
            this.btnInverte.TabIndex = 4;
            this.btnInverte.Text = "Inverter";
            this.btnInverte.UseVisualStyleBackColor = true;
            this.btnInverte.Click += new System.EventHandler(this.BtnInverte_Click);
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(90, 60);
            this.lblPalavra1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(61, 16);
            this.lblPalavra1.TabIndex = 5;
            this.lblPalavra1.Text = "Palavra1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(298, 60);
            this.lblPalavra2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(61, 16);
            this.lblPalavra2.TabIndex = 6;
            this.lblPalavra2.Text = "Palavra2";
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 376);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.btnInverte);
            this.Controls.Add(this.btnRemova2);
            this.Controls.Add(this.btnRemova1);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.txtPalavra2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.Button btnRemova1;
        private System.Windows.Forms.Button btnRemova2;
        private System.Windows.Forms.Button btnInverte;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
    }
}