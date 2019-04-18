namespace CGLab1
{
    partial class ConvMatrix
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.convolutionFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gausToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.northToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.southToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.westToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.southEastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convolutionFiltersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // convolutionFiltersToolStripMenuItem
            // 
            this.convolutionFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.gausToolStripMenuItem,
            this.sharpenFilterToolStripMenuItem,
            this.edgeToolStripMenuItem,
            this.embossToolStripMenuItem});
            this.convolutionFiltersToolStripMenuItem.Name = "convolutionFiltersToolStripMenuItem";
            this.convolutionFiltersToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.convolutionFiltersToolStripMenuItem.Text = "Convolution Filters";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // gausToolStripMenuItem
            // 
            this.gausToolStripMenuItem.Name = "gausToolStripMenuItem";
            this.gausToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.gausToolStripMenuItem.Text = "Gaussian Smoothing";
            this.gausToolStripMenuItem.Click += new System.EventHandler(this.gausToolStripMenuItem_Click);
            // 
            // sharpenFilterToolStripMenuItem
            // 
            this.sharpenFilterToolStripMenuItem.Name = "sharpenFilterToolStripMenuItem";
            this.sharpenFilterToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.sharpenFilterToolStripMenuItem.Text = "Sharpen Filter";
            this.sharpenFilterToolStripMenuItem.Click += new System.EventHandler(this.sharpenFilterToolStripMenuItem_Click);
            // 
            // edgeToolStripMenuItem
            // 
            this.edgeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.diagonalToolStripMenuItem});
            this.edgeToolStripMenuItem.Name = "edgeToolStripMenuItem";
            this.edgeToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.edgeToolStripMenuItem.Text = "Edge";
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // diagonalToolStripMenuItem
            // 
            this.diagonalToolStripMenuItem.Name = "diagonalToolStripMenuItem";
            this.diagonalToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.diagonalToolStripMenuItem.Text = "Diagonal";
            this.diagonalToolStripMenuItem.Click += new System.EventHandler(this.diagonalToolStripMenuItem_Click);
            // 
            // embossToolStripMenuItem
            // 
            this.embossToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.northToolStripMenuItem,
            this.southToolStripMenuItem,
            this.eastToolStripMenuItem,
            this.westToolStripMenuItem,
            this.southEastToolStripMenuItem});
            this.embossToolStripMenuItem.Name = "embossToolStripMenuItem";
            this.embossToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.embossToolStripMenuItem.Text = "Emboss";
            // 
            // northToolStripMenuItem
            // 
            this.northToolStripMenuItem.Name = "northToolStripMenuItem";
            this.northToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.northToolStripMenuItem.Text = "North";
            this.northToolStripMenuItem.Click += new System.EventHandler(this.northToolStripMenuItem_Click);
            // 
            // southToolStripMenuItem
            // 
            this.southToolStripMenuItem.Name = "southToolStripMenuItem";
            this.southToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.southToolStripMenuItem.Text = "South";
            this.southToolStripMenuItem.Click += new System.EventHandler(this.southToolStripMenuItem_Click);
            // 
            // eastToolStripMenuItem
            // 
            this.eastToolStripMenuItem.Name = "eastToolStripMenuItem";
            this.eastToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.eastToolStripMenuItem.Text = "East";
            this.eastToolStripMenuItem.Click += new System.EventHandler(this.eastToolStripMenuItem_Click);
            // 
            // westToolStripMenuItem
            // 
            this.westToolStripMenuItem.Name = "westToolStripMenuItem";
            this.westToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.westToolStripMenuItem.Text = "West";
            this.westToolStripMenuItem.Click += new System.EventHandler(this.westToolStripMenuItem_Click);
            // 
            // southEastToolStripMenuItem
            // 
            this.southEastToolStripMenuItem.Name = "southEastToolStripMenuItem";
            this.southEastToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.southEastToolStripMenuItem.Text = "South-East";
            this.southEastToolStripMenuItem.Click += new System.EventHandler(this.southEastToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 318);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 150);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "x";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(232, 95);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(75, 22);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "x";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(131, 95);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(75, 22);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.generate_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(131, 67);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 22);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Anchor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Offset:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Divisor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter matrix size:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(743, 531);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(3, 483);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(737, 45);
            this.panel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.apply_Click);
            // 
            // ConvMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 561);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConvMatrix";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem convolutionFiltersToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gausToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem southToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eastToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem southEastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem northToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem westToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
    }
}