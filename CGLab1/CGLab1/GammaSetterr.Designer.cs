namespace CGLab1
{
    partial class GammaSetterr
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
            this.gammaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gammaText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gammaButton
            // 
            this.gammaButton.Location = new System.Drawing.Point(259, 84);
            this.gammaButton.Name = "gammaButton";
            this.gammaButton.Size = new System.Drawing.Size(87, 32);
            this.gammaButton.TabIndex = 0;
            this.gammaButton.Text = "Apply";
            this.gammaButton.UseVisualStyleBackColor = true;
            this.gammaButton.Click += new System.EventHandler(this.gammaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter exponent value:";
            // 
            // gammaText
            // 
            this.gammaText.Location = new System.Drawing.Point(259, 45);
            this.gammaText.Name = "gammaText";
            this.gammaText.Size = new System.Drawing.Size(100, 22);
            this.gammaText.TabIndex = 2;
            // 
            // GammaSetterr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 175);
            this.Controls.Add(this.gammaText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gammaButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GammaSetterr";
            this.Text = "GammaSetterr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gammaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gammaText;
    }
}