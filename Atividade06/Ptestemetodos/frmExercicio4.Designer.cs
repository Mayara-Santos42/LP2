namespace Ptestemetodos
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
            this.txtMain = new System.Windows.Forms.RichTextBox();
            this.btnNum = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnAlfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(121, 31);
            this.txtMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(407, 117);
            this.txtMain.TabIndex = 0;
            this.txtMain.Text = "";
            // 
            // btnNum
            // 
            this.btnNum.Location = new System.Drawing.Point(100, 210);
            this.btnNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(100, 63);
            this.btnNum.TabIndex = 1;
            this.btnNum.Text = "Contar char numerico";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(282, 210);
            this.btnBranco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(100, 63);
            this.btnBranco.TabIndex = 2;
            this.btnBranco.Text = "Localizar 1º char branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.BtnBranco_Click);
            // 
            // btnAlfa
            // 
            this.btnAlfa.Location = new System.Drawing.Point(449, 210);
            this.btnAlfa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlfa.Name = "btnAlfa";
            this.btnAlfa.Size = new System.Drawing.Size(100, 63);
            this.btnAlfa.TabIndex = 3;
            this.btnAlfa.Text = "Contar char alfabético";
            this.btnAlfa.UseVisualStyleBackColor = true;
            this.btnAlfa.Click += new System.EventHandler(this.btnAlfa_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 376);
            this.Controls.Add(this.btnAlfa);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.txtMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExercicio4";
            this.Text = "frnExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMain;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnAlfa;
    }
}