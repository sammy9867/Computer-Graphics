namespace CGLab4
{
    partial class ClippingAndFilling
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clippingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.labButton = new System.Windows.Forms.Button();
            this.colorFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.clipButton = new System.Windows.Forms.Button();
            this.yLineLabel = new System.Windows.Forms.Label();
            this.xLineLabel = new System.Windows.Forms.Label();
            this.lineButton = new System.Windows.Forms.Button();
            this.coordinatesLabel = new System.Windows.Forms.Label();
            this.fillButton = new System.Windows.Forms.Button();
            this.polyButton = new System.Windows.Forms.Button();
            this.yPolyLabel = new System.Windows.Forms.Label();
            this.xPolyLabel = new System.Windows.Forms.Label();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.mode = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(692, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clippingToolStripMenuItem,
            this.fillingToolStripMenuItem,
            this.labToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clippingToolStripMenuItem
            // 
            this.clippingToolStripMenuItem.Name = "clippingToolStripMenuItem";
            this.clippingToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.clippingToolStripMenuItem.Text = "Clipping";
            this.clippingToolStripMenuItem.Click += new System.EventHandler(this.clippingToolStripMenuItem_Click);
            // 
            // fillingToolStripMenuItem
            // 
            this.fillingToolStripMenuItem.Name = "fillingToolStripMenuItem";
            this.fillingToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.fillingToolStripMenuItem.Text = "Filling";
            this.fillingToolStripMenuItem.Click += new System.EventHandler(this.fillingToolStripMenuItem_Click);
            // 
            // labToolStripMenuItem1
            // 
            this.labToolStripMenuItem1.Name = "labToolStripMenuItem1";
            this.labToolStripMenuItem1.Size = new System.Drawing.Size(140, 26);
            this.labToolStripMenuItem1.Text = "Lab";
            this.labToolStripMenuItem1.Click += new System.EventHandler(this.labToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this.leftPanel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.mainPictureBox, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 407F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(692, 407);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.labButton);
            this.leftPanel.Controls.Add(this.colorFlowLayoutPanel);
            this.leftPanel.Controls.Add(this.clipButton);
            this.leftPanel.Controls.Add(this.yLineLabel);
            this.leftPanel.Controls.Add(this.xLineLabel);
            this.leftPanel.Controls.Add(this.lineButton);
            this.leftPanel.Controls.Add(this.coordinatesLabel);
            this.leftPanel.Controls.Add(this.fillButton);
            this.leftPanel.Controls.Add(this.polyButton);
            this.leftPanel.Controls.Add(this.yPolyLabel);
            this.leftPanel.Controls.Add(this.xPolyLabel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(556, 2);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(133, 403);
            this.leftPanel.TabIndex = 0;
            // 
            // labButton
            // 
            this.labButton.Location = new System.Drawing.Point(6, 271);
            this.labButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labButton.Name = "labButton";
            this.labButton.Size = new System.Drawing.Size(89, 40);
            this.labButton.TabIndex = 11;
            this.labButton.Text = "Lab";
            this.labButton.UseVisualStyleBackColor = true;
            this.labButton.Click += new System.EventHandler(this.labButton_Click);
            // 
            // colorFlowLayoutPanel
            // 
            this.colorFlowLayoutPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.colorFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.colorFlowLayoutPanel.Location = new System.Drawing.Point(0, 315);
            this.colorFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorFlowLayoutPanel.Name = "colorFlowLayoutPanel";
            this.colorFlowLayoutPanel.Size = new System.Drawing.Size(133, 88);
            this.colorFlowLayoutPanel.TabIndex = 1;
            // 
            // clipButton
            // 
            this.clipButton.Location = new System.Drawing.Point(3, 183);
            this.clipButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clipButton.Name = "clipButton";
            this.clipButton.Size = new System.Drawing.Size(89, 40);
            this.clipButton.TabIndex = 9;
            this.clipButton.Text = "Clip";
            this.clipButton.UseVisualStyleBackColor = true;
            this.clipButton.Click += new System.EventHandler(this.clipButton_Click);
            // 
            // yLineLabel
            // 
            this.yLineLabel.AutoSize = true;
            this.yLineLabel.Location = new System.Drawing.Point(72, 164);
            this.yLineLabel.Name = "yLineLabel";
            this.yLineLabel.Size = new System.Drawing.Size(17, 17);
            this.yLineLabel.TabIndex = 8;
            this.yLineLabel.Text = "Y";
            // 
            // xLineLabel
            // 
            this.xLineLabel.AutoSize = true;
            this.xLineLabel.Location = new System.Drawing.Point(0, 164);
            this.xLineLabel.Name = "xLineLabel";
            this.xLineLabel.Size = new System.Drawing.Size(21, 17);
            this.xLineLabel.TabIndex = 7;
            this.xLineLabel.Text = "X ";
            // 
            // lineButton
            // 
            this.lineButton.Location = new System.Drawing.Point(0, 121);
            this.lineButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(89, 41);
            this.lineButton.TabIndex = 6;
            this.lineButton.Text = "Draw Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // coordinatesLabel
            // 
            this.coordinatesLabel.AutoSize = true;
            this.coordinatesLabel.Location = new System.Drawing.Point(3, 14);
            this.coordinatesLabel.Name = "coordinatesLabel";
            this.coordinatesLabel.Size = new System.Drawing.Size(36, 17);
            this.coordinatesLabel.TabIndex = 5;
            this.coordinatesLabel.Text = "[0;0]";
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(3, 227);
            this.fillButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(89, 40);
            this.fillButton.TabIndex = 4;
            this.fillButton.Text = "Fill";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // polyButton
            // 
            this.polyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.polyButton.AutoSize = true;
            this.polyButton.Location = new System.Drawing.Point(0, 43);
            this.polyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.polyButton.Name = "polyButton";
            this.polyButton.Size = new System.Drawing.Size(105, 40);
            this.polyButton.TabIndex = 3;
            this.polyButton.Text = "Draw Polygon";
            this.polyButton.UseVisualStyleBackColor = true;
            this.polyButton.Click += new System.EventHandler(this.polyButton_Click);
            // 
            // yPolyLabel
            // 
            this.yPolyLabel.AutoSize = true;
            this.yPolyLabel.Location = new System.Drawing.Point(72, 85);
            this.yPolyLabel.Name = "yPolyLabel";
            this.yPolyLabel.Size = new System.Drawing.Size(17, 17);
            this.yPolyLabel.TabIndex = 2;
            this.yPolyLabel.Text = "Y";
            // 
            // xPolyLabel
            // 
            this.xPolyLabel.AutoSize = true;
            this.xPolyLabel.Location = new System.Drawing.Point(0, 85);
            this.xPolyLabel.Name = "xPolyLabel";
            this.xPolyLabel.Size = new System.Drawing.Size(21, 17);
            this.xPolyLabel.TabIndex = 1;
            this.xPolyLabel.Text = "X ";
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackColor = System.Drawing.Color.White;
            this.mainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPictureBox.Location = new System.Drawing.Point(3, 2);
            this.mainPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(547, 403);
            this.mainPictureBox.TabIndex = 1;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.Click += new System.EventHandler(this.mainPictureBox_Click);
            this.mainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseMove);
            // 
            // mode
            // 
            this.mode.AutoSize = true;
            this.mode.Location = new System.Drawing.Point(-3, 51);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(107, 17);
            this.mode.TabIndex = 10;
            this.mode.Text = "MODE: Clipping";
            // 
            // ClippingAndFilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 435);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClippingAndFilling";
            this.Text = "ClippingAndFilling";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Label yPolyLabel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel colorFlowLayoutPanel;
        private System.Windows.Forms.Button polyButton;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Label coordinatesLabel;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Label yLineLabel;
        private System.Windows.Forms.Label xLineLabel;
        private System.Windows.Forms.Button clipButton;
        private System.Windows.Forms.ToolStripMenuItem clippingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labToolStripMenuItem1;
        private System.Windows.Forms.Label mode;
        private System.Windows.Forms.Label xPolyLabel;
        private System.Windows.Forms.Button labButton;
    }
}

