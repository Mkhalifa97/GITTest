namespace GITTest
{
    partial class Form1
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
            this.btnryan = new System.Windows.Forms.Button();
            this.php = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnryan
            // 
            this.btnryan.Location = new System.Drawing.Point(132, 133);
            this.btnryan.Name = "btnryan";
            this.btnryan.Size = new System.Drawing.Size(95, 23);
            this.btnryan.TabIndex = 10;
            this.btnryan.Text = "RYanHAyton";
            this.btnryan.UseVisualStyleBackColor = true;
            // 
            // php
            // 
            this.php.AutoSize = true;
            this.php.Location = new System.Drawing.Point(143, 199);
            this.php.Name = "php";
            this.php.Size = new System.Drawing.Size(39, 13);
            this.php.TabIndex = 10;
            this.php.Text = "Clyde4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label php;
        private System.Windows.Forms.Button btnryan;
    }
}

