namespace CGLab1
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
            this.components = new System.ComponentModel.Container();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.filteredPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionalFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyScaleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.applyThresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomDitheringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.octreeColorQuantizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteredPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalPictureBox.Location = new System.Drawing.Point(3, 2);
            this.originalPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(481, 510);
            this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalPictureBox.TabIndex = 0;
            this.originalPictureBox.TabStop = false;
            // 
            // filteredPictureBox
            // 
            this.filteredPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filteredPictureBox.Location = new System.Drawing.Point(490, 2);
            this.filteredPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filteredPictureBox.Name = "filteredPictureBox";
            this.filteredPictureBox.Size = new System.Drawing.Size(481, 510);
            this.filteredPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filteredPictureBox.TabIndex = 1;
            this.filteredPictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.matrixToolStripMenuItem,
            this.lab2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(974, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.functionalFiltersToolStripMenuItem,
            this.convolutionFiltersToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // functionalFiltersToolStripMenuItem
            // 
            this.functionalFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identityToolStripMenuItem,
            this.inverToolStripMenuItem,
            this.brightnessToolStripMenuItem,
            this.contrastToolStripMenuItem,
            this.gammaCorrectionToolStripMenuItem});
            this.functionalFiltersToolStripMenuItem.Name = "functionalFiltersToolStripMenuItem";
            this.functionalFiltersToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.functionalFiltersToolStripMenuItem.Text = "Functional Filters";
            // 
            // identityToolStripMenuItem
            // 
            this.identityToolStripMenuItem.Name = "identityToolStripMenuItem";
            this.identityToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.identityToolStripMenuItem.Text = "Identity";
            this.identityToolStripMenuItem.Click += new System.EventHandler(this.identityToolStripMenuItem_Click);
            // 
            // inverToolStripMenuItem
            // 
            this.inverToolStripMenuItem.Name = "inverToolStripMenuItem";
            this.inverToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.inverToolStripMenuItem.Text = "Inversion";
            this.inverToolStripMenuItem.Click += new System.EventHandler(this.inverToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increaseToolStripMenuItem,
            this.decreaseToolStripMenuItem});
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            // 
            // increaseToolStripMenuItem
            // 
            this.increaseToolStripMenuItem.Name = "increaseToolStripMenuItem";
            this.increaseToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.increaseToolStripMenuItem.Text = "Increase";
            this.increaseToolStripMenuItem.Click += new System.EventHandler(this.increaseToolStripMenuItem_Click);
            // 
            // decreaseToolStripMenuItem
            // 
            this.decreaseToolStripMenuItem.Name = "decreaseToolStripMenuItem";
            this.decreaseToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.decreaseToolStripMenuItem.Text = "Decrease";
            this.decreaseToolStripMenuItem.Click += new System.EventHandler(this.decreaseToolStripMenuItem_Click);
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.contrastToolStripMenuItem.Text = "Contrast";
            this.contrastToolStripMenuItem.Click += new System.EventHandler(this.contrastToolStripMenuItem_Click);
            // 
            // gammaCorrectionToolStripMenuItem
            // 
            this.gammaCorrectionToolStripMenuItem.Name = "gammaCorrectionToolStripMenuItem";
            this.gammaCorrectionToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.gammaCorrectionToolStripMenuItem.Text = "Gamma Correction";
            this.gammaCorrectionToolStripMenuItem.Click += new System.EventHandler(this.gammaCorrectionToolStripMenuItem_Click);
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
            this.convolutionFiltersToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.ShowShortcutKeys = false;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // matrixToolStripMenuItem
            // 
            this.matrixToolStripMenuItem.Name = "matrixToolStripMenuItem";
            this.matrixToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.matrixToolStripMenuItem.Text = "Matrix";
            this.matrixToolStripMenuItem.Click += new System.EventHandler(this.matrixToolStripMenuItem_Click);
            // 
            // lab2ToolStripMenuItem
            // 
            this.lab2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greyScaleToolStripMenuItem1,
            this.applyThresholdToolStripMenuItem,
            this.randomDitheringToolStripMenuItem,
            this.octreeColorQuantizationToolStripMenuItem});
            this.lab2ToolStripMenuItem.Name = "lab2ToolStripMenuItem";
            this.lab2ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.lab2ToolStripMenuItem.Text = "Lab2";
            // 
            // greyScaleToolStripMenuItem1
            // 
            this.greyScaleToolStripMenuItem1.Name = "greyScaleToolStripMenuItem1";
            this.greyScaleToolStripMenuItem1.Size = new System.Drawing.Size(253, 26);
            this.greyScaleToolStripMenuItem1.Text = "Grey Scale";
            this.greyScaleToolStripMenuItem1.Click += new System.EventHandler(this.greyScaleToolStripMenuItem1_Click);
            // 
            // applyThresholdToolStripMenuItem
            // 
            this.applyThresholdToolStripMenuItem.Name = "applyThresholdToolStripMenuItem";
            this.applyThresholdToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.applyThresholdToolStripMenuItem.Text = "Apply Threshold";
            this.applyThresholdToolStripMenuItem.Click += new System.EventHandler(this.applyThresholdToolStripMenuItem_Click);
            // 
            // randomDitheringToolStripMenuItem
            // 
            this.randomDitheringToolStripMenuItem.Name = "randomDitheringToolStripMenuItem";
            this.randomDitheringToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.randomDitheringToolStripMenuItem.Text = "Random Dithering";
            this.randomDitheringToolStripMenuItem.Click += new System.EventHandler(this.randomDitheringToolStripMenuItem_Click);
            // 
            // octreeColorQuantizationToolStripMenuItem
            // 
            this.octreeColorQuantizationToolStripMenuItem.Name = "octreeColorQuantizationToolStripMenuItem";
            this.octreeColorQuantizationToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.octreeColorQuantizationToolStripMenuItem.Text = "Octree color quantization";
            this.octreeColorQuantizationToolStripMenuItem.Click += new System.EventHandler(this.octreeColorQuantizationToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.originalPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.filteredPictureBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(974, 514);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 542);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filters";
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteredPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.PictureBox filteredPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionalFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convolutionFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem identityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gammaCorrectionToolStripMenuItem;


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
        private System.Windows.Forms.ToolStripMenuItem southEastToolStripMenuItem;

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem matrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem northToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem westToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyScaleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem applyThresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomDitheringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem octreeColorQuantizationToolStripMenuItem;
    }
}

