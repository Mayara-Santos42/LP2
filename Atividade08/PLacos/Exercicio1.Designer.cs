namespace PLacos
{
    partial class Exercicio1
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
            this.btnEspaco = new System.Windows.Forms.Button();
            this.rtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnLetraRepetida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEspaco
            // 
            this.btnEspaco.Location = new System.Drawing.Point(183, 306);
            this.btnEspaco.Name = "btnEspaco";
            this.btnEspaco.Size = new System.Drawing.Size(106, 48);
            this.btnEspaco.TabIndex = 0;
            this.btnEspaco.Text = "Num espaco em branco";
            this.btnEspaco.UseVisualStyleBackColor = true;
            this.btnEspaco.Click += new System.EventHandler(this.BtnEspaco_Click);
            // 
            // rtxtFrase
            // 
            this.rtxtFrase.Location = new System.Drawing.Point(222, 159);
            this.rtxtFrase.Name = "rtxtFrase";
            this.rtxtFrase.Size = new System.Drawing.Size(293, 96);
            this.rtxtFrase.TabIndex = 1;
            this.rtxtFrase.Text = "";
            this.rtxtFrase.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Location = new System.Drawing.Point(334, 306);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(75, 48);
            this.btnLetraR.TabIndex = 2;
            this.btnLetraR.Text = "Contar R";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.BtnLetraR_Click);
            // 
            // btnLetraRepetida
            // 
            this.btnLetraRepetida.Location = new System.Drawing.Point(440, 306);
            this.btnLetraRepetida.Name = "btnLetraRepetida";
            this.btnLetraRepetida.Size = new System.Drawing.Size(75, 48);
            this.btnLetraRepetida.TabIndex = 3;
            this.btnLetraRepetida.Text = "Par de Letras";
            this.btnLetraRepetida.UseVisualStyleBackColor = true;
            this.btnLetraRepetida.Click += new System.EventHandler(this.BtnLetraRepetida_Click);
            // 
            // Exercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLetraRepetida);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.rtxtFrase);
            this.Controls.Add(this.btnEspaco);
            this.Name = "Exercicio1";
            this.Text = "Exercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEspaco;
        private System.Windows.Forms.RichTextBox rtxtFrase;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnLetraRepetida;
    }
}