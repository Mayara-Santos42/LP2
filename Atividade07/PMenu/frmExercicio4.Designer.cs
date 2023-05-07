namespace PMenu
{
    partial class frmExercicio4
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
            this.btnLetras = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnNum = new System.Windows.Forms.Button();
            this.rchtxtInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnLetras
            // 
            this.btnLetras.Location = new System.Drawing.Point(455, 209);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(89, 50);
            this.btnLetras.TabIndex = 7;
            this.btnLetras.Text = "Caracteres alfabeticos";
            this.btnLetras.UseVisualStyleBackColor = true;
            this.btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(340, 209);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(89, 50);
            this.btnBranco.TabIndex = 6;
            this.btnBranco.Text = "Primeiro caracter branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnNum
            // 
            this.btnNum.Location = new System.Drawing.Point(221, 209);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(89, 50);
            this.btnNum.TabIndex = 5;
            this.btnNum.Text = "Caracteres numéricos";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // rchtxtInput
            // 
            this.rchtxtInput.Location = new System.Drawing.Point(130, 103);
            this.rchtxtInput.Name = "rchtxtInput";
            this.rchtxtInput.Size = new System.Drawing.Size(548, 45);
            this.rchtxtInput.TabIndex = 4;
            this.rchtxtInput.Text = "";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLetras);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.rchtxtInput);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLetras;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.RichTextBox rchtxtInput;
    }
}