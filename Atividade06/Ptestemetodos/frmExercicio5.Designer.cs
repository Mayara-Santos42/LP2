namespace Ptestemetodos
{
    partial class frmExercicio5
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
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnSortear = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(277, 58);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(132, 22);
            this.txtNum2.TabIndex = 0;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtBoxNum2_TextChanged);
            // 
            // btnSortear
            // 
            this.btnSortear.Location = new System.Drawing.Point(186, 130);
            this.btnSortear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(100, 28);
            this.btnSortear.TabIndex = 1;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(74, 58);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(132, 22);
            this.txtNum1.TabIndex = 2;
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 315);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.txtNum2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExercicio5";
            this.Text = "frmExercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.TextBox txtNum1;
    }
}