namespace FeebasLocatorPlugin
{
    partial class FeebasLocatorForm
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
            this.TilePanel = new System.Windows.Forms.Panel();
            this.FeebasLocatorPanel = new System.Windows.Forms.Panel();
            this.Route119Label = new System.Windows.Forms.Label();
            this.FeebasSeedLabel = new System.Windows.Forms.Label();
            this.FeebasSeedBox = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FeebasLocatorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeebasSeedBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TilePanel
            // 
            this.TilePanel.BackgroundImage = global::FeebasLocatorPlugin.Properties.Resources.route119;
            this.TilePanel.Location = new System.Drawing.Point(0, 0);
            this.TilePanel.MaximumSize = new System.Drawing.Size(641, 1553);
            this.TilePanel.MinimumSize = new System.Drawing.Size(641, 1553);
            this.TilePanel.Name = "TilePanel";
            this.TilePanel.Size = new System.Drawing.Size(641, 1553);
            this.TilePanel.TabIndex = 0;
            // 
            // FeebasLocatorPanel
            // 
            this.FeebasLocatorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FeebasLocatorPanel.AutoScroll = true;
            this.FeebasLocatorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FeebasLocatorPanel.Controls.Add(this.TilePanel);
            this.FeebasLocatorPanel.Location = new System.Drawing.Point(12, 25);
            this.FeebasLocatorPanel.Name = "FeebasLocatorPanel";
            this.FeebasLocatorPanel.Size = new System.Drawing.Size(660, 290);
            this.FeebasLocatorPanel.TabIndex = 4;
            // 
            // Route119Label
            // 
            this.Route119Label.AutoSize = true;
            this.Route119Label.Location = new System.Drawing.Point(9, 9);
            this.Route119Label.Name = "Route119Label";
            this.Route119Label.Size = new System.Drawing.Size(57, 13);
            this.Route119Label.TabIndex = 3;
            this.Route119Label.Text = "Route 119";
            // 
            // FeebasSeedLabel
            // 
            this.FeebasSeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FeebasSeedLabel.AutoSize = true;
            this.FeebasSeedLabel.Location = new System.Drawing.Point(10, 326);
            this.FeebasSeedLabel.Name = "FeebasSeedLabel";
            this.FeebasSeedLabel.Size = new System.Drawing.Size(70, 13);
            this.FeebasSeedLabel.TabIndex = 2;
            this.FeebasSeedLabel.Text = "Feebas Seed";
            // 
            // FeebasSeedBox
            // 
            this.FeebasSeedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FeebasSeedBox.Hexadecimal = true;
            this.FeebasSeedBox.Location = new System.Drawing.Point(86, 324);
            this.FeebasSeedBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.FeebasSeedBox.Name = "FeebasSeedBox";
            this.FeebasSeedBox.Size = new System.Drawing.Size(52, 20);
            this.FeebasSeedBox.TabIndex = 0;
            this.FeebasSeedBox.ValueChanged += new System.EventHandler(this.FeebasSeedBox_ValueChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveButton.Location = new System.Drawing.Point(597, 321);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 26);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FeebasLocatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 359);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FeebasSeedBox);
            this.Controls.Add(this.FeebasSeedLabel);
            this.Controls.Add(this.Route119Label);
            this.Controls.Add(this.FeebasLocatorPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(701, 2000);
            this.MinimumSize = new System.Drawing.Size(701, 223);
            this.Name = "FeebasLocatorForm";
            this.ShowIcon = false;
            this.Text = "Feebas Locator";
            this.FeebasLocatorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FeebasSeedBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TilePanel;
        private System.Windows.Forms.Panel FeebasLocatorPanel;
        private System.Windows.Forms.Label Route119Label;
        private System.Windows.Forms.Label FeebasSeedLabel;
        private System.Windows.Forms.NumericUpDown FeebasSeedBox;
        private System.Windows.Forms.Button SaveButton;
    }
}