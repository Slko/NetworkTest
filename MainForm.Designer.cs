namespace NetworkTest
{
    partial class MainForm
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
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.portNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.sendPacketButton = new System.Windows.Forms.Button();
            this.listenButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(12, 9);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(20, 13);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "IP:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(69, 6);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(100, 20);
            this.ipTextBox.TabIndex = 1;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(12, 34);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 13);
            this.portLabel.TabIndex = 2;
            this.portLabel.Text = "Port:";
            // 
            // portNumericUpDown
            // 
            this.portNumericUpDown.Location = new System.Drawing.Point(69, 32);
            this.portNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portNumericUpDown.Name = "portNumericUpDown";
            this.portNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.portNumericUpDown.TabIndex = 3;
            this.portNumericUpDown.Value = new decimal(new int[] {
            7700,
            0,
            0,
            0});
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.Location = new System.Drawing.Point(12, 84);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(304, 124);
            this.logTextBox.TabIndex = 4;
            // 
            // sendPacketButton
            // 
            this.sendPacketButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendPacketButton.Location = new System.Drawing.Point(322, 84);
            this.sendPacketButton.Name = "sendPacketButton";
            this.sendPacketButton.Size = new System.Drawing.Size(89, 23);
            this.sendPacketButton.TabIndex = 5;
            this.sendPacketButton.Text = "Send packet";
            this.sendPacketButton.UseVisualStyleBackColor = true;
            this.sendPacketButton.Click += new System.EventHandler(this.sendPacketButton_Click);
            // 
            // listenButton
            // 
            this.listenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listenButton.Location = new System.Drawing.Point(322, 113);
            this.listenButton.Name = "listenButton";
            this.listenButton.Size = new System.Drawing.Size(89, 23);
            this.listenButton.TabIndex = 6;
            this.listenButton.Text = "Listen";
            this.listenButton.UseVisualStyleBackColor = true;
            this.listenButton.Click += new System.EventHandler(this.listenButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(322, 185);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(89, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(12, 60);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(30, 13);
            this.sizeLabel.TabIndex = 8;
            this.sizeLabel.Text = "Size:";
            // 
            // sizeNumericUpDown
            // 
            this.sizeNumericUpDown.Location = new System.Drawing.Point(69, 58);
            this.sizeNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.sizeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeNumericUpDown.Name = "sizeNumericUpDown";
            this.sizeNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.sizeNumericUpDown.TabIndex = 9;
            this.sizeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 220);
            this.Controls.Add(this.sizeNumericUpDown);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.listenButton);
            this.Controls.Add(this.sendPacketButton);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.portNumericUpDown);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.ipLabel);
            this.Name = "MainForm";
            this.Text = "NetworkTest";
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.NumericUpDown portNumericUpDown;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button sendPacketButton;
        private System.Windows.Forms.Button listenButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.NumericUpDown sizeNumericUpDown;
    }
}

