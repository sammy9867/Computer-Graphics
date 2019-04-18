namespace CGLab3
{
    partial class Drawing
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.drawPictureBox = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.decreaseThicknessButton = new System.Windows.Forms.Button();
            this.increaseThicknessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.thicknessLabel = new System.Windows.Forms.Label();
            this.pictureSizeLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.modeLabel = new System.Windows.Forms.Label();
            this.colorFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.midpointCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xaolinWuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawPictureBox)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.Controls.Add(this.drawPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.leftPanel, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 414F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(695, 414);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // drawPictureBox
            // 
            this.drawPictureBox.BackColor = System.Drawing.Color.White;
            this.drawPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawPictureBox.Location = new System.Drawing.Point(3, 2);
            this.drawPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drawPictureBox.Name = "drawPictureBox";
            this.drawPictureBox.Size = new System.Drawing.Size(584, 410);
            this.drawPictureBox.TabIndex = 1;
            this.drawPictureBox.TabStop = false;
            this.drawPictureBox.Click += new System.EventHandler(this.drawPictureBox_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.infoPanel);
            this.leftPanel.Controls.Add(this.colorFlowLayoutPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(593, 2);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(99, 410);
            this.leftPanel.TabIndex = 2;
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.decreaseThicknessButton);
            this.infoPanel.Controls.Add(this.increaseThicknessButton);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Controls.Add(this.thicknessLabel);
            this.infoPanel.Controls.Add(this.pictureSizeLabel);
            this.infoPanel.Controls.Add(this.yLabel);
            this.infoPanel.Controls.Add(this.xLabel);
            this.infoPanel.Controls.Add(this.modeLabel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(99, 412);
            this.infoPanel.TabIndex = 2;
            // 
            // decreaseThicknessButton
            // 
            this.decreaseThicknessButton.Location = new System.Drawing.Point(52, 151);
            this.decreaseThicknessButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decreaseThicknessButton.Name = "decreaseThicknessButton";
            this.decreaseThicknessButton.Size = new System.Drawing.Size(27, 24);
            this.decreaseThicknessButton.TabIndex = 7;
            this.decreaseThicknessButton.Text = "-";
            this.decreaseThicknessButton.UseVisualStyleBackColor = true;
            this.decreaseThicknessButton.Click += new System.EventHandler(this.decreaseThicknessButton_Click);
            // 
            // increaseThicknessButton
            // 
            this.increaseThicknessButton.Location = new System.Drawing.Point(14, 151);
            this.increaseThicknessButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.increaseThicknessButton.Name = "increaseThicknessButton";
            this.increaseThicknessButton.Size = new System.Drawing.Size(27, 24);
            this.increaseThicknessButton.TabIndex = 6;
            this.increaseThicknessButton.Text = "+";
            this.increaseThicknessButton.UseVisualStyleBackColor = true;
            this.increaseThicknessButton.Click += new System.EventHandler(this.increaseThicknessButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "THICKNESS";
            // 
            // thicknessLabel
            // 
            this.thicknessLabel.AutoSize = true;
            this.thicknessLabel.Location = new System.Drawing.Point(11, 180);
            this.thicknessLabel.Name = "thicknessLabel";
            this.thicknessLabel.Size = new System.Drawing.Size(67, 17);
            this.thicknessLabel.TabIndex = 4;
            this.thicknessLabel.Text = "thickness";
            // 
            // pictureSizeLabel
            // 
            this.pictureSizeLabel.AutoSize = true;
            this.pictureSizeLabel.Location = new System.Drawing.Point(11, 106);
            this.pictureSizeLabel.Name = "pictureSizeLabel";
            this.pictureSizeLabel.Size = new System.Drawing.Size(78, 17);
            this.pictureSizeLabel.TabIndex = 3;
            this.pictureSizeLabel.Text = "pictureSize";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(11, 79);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(21, 17);
            this.yLabel.TabIndex = 2;
            this.yLabel.Text = "Y:";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(11, 53);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(25, 17);
            this.xLabel.TabIndex = 1;
            this.xLabel.Text = "X: ";
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(11, 13);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(43, 17);
            this.modeLabel.TabIndex = 0;
            this.modeLabel.Text = "Mode";
            // 
            // colorFlowLayoutPanel
            // 
            this.colorFlowLayoutPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.colorFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.colorFlowLayoutPanel.Location = new System.Drawing.Point(0, 41);
            this.colorFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorFlowLayoutPanel.Name = "colorFlowLayoutPanel";
            this.colorFlowLayoutPanel.Size = new System.Drawing.Size(99, 369);
            this.colorFlowLayoutPanel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(695, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem,
            this.midpointCircleToolStripMenuItem,
            this.xaolinWuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.lineToolStripMenuItem.Text = "Midpoint Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // midpointCircleToolStripMenuItem
            // 
            this.midpointCircleToolStripMenuItem.Name = "midpointCircleToolStripMenuItem";
            this.midpointCircleToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.midpointCircleToolStripMenuItem.Text = "Alternate Midpoint circle";
            this.midpointCircleToolStripMenuItem.Click += new System.EventHandler(this.midpointCircleToolStripMenuItem_Click);
            // 
            // xaolinWuToolStripMenuItem
            // 
            this.xaolinWuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem1,
            this.circleToolStripMenuItem});
            this.xaolinWuToolStripMenuItem.Name = "xaolinWuToolStripMenuItem";
            this.xaolinWuToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.xaolinWuToolStripMenuItem.Text = "Xaolin Wu";
            // 
            // lineToolStripMenuItem1
            // 
            this.lineToolStripMenuItem1.Name = "lineToolStripMenuItem1";
            this.lineToolStripMenuItem1.Size = new System.Drawing.Size(121, 26);
            this.lineToolStripMenuItem1.Text = "Line";
            this.lineToolStripMenuItem1.Click += new System.EventHandler(this.lineToolStripMenuItem1_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // Drawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 442);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(713, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(713, 489);
            this.Name = "Drawing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drawing";
            this.Load += new System.EventHandler(this.Drawing_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawPictureBox)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem midpointCircleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xaolinWuToolStripMenuItem;
        private System.Windows.Forms.PictureBox drawPictureBox;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.FlowLayoutPanel colorFlowLayoutPanel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label pictureSizeLabel;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.Label thicknessLabel;
        private System.Windows.Forms.Button decreaseThicknessButton;
        private System.Windows.Forms.Button increaseThicknessButton;
        private System.Windows.Forms.Label label1;
    }
}

