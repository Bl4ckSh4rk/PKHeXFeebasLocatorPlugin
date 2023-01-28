namespace FeebasLocatorPlugin;

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
        this.LocationLabel = new System.Windows.Forms.Label();
        this.FeebasSeedLabel = new System.Windows.Forms.Label();
        this.SaveButton = new System.Windows.Forms.Button();
        this.FeebasSeedBox = new System.Windows.Forms.TextBox();
        this.FeebasLocatorPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // TilePanel
        // 
        this.TilePanel.Location = new System.Drawing.Point(0, 0);
        this.TilePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.TilePanel.Name = "TilePanel";
        this.TilePanel.Size = new System.Drawing.Size(233, 115);
        this.TilePanel.TabIndex = 0;
        // 
        // FeebasLocatorPanel
        // 
        this.FeebasLocatorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        | System.Windows.Forms.AnchorStyles.Left)));
        this.FeebasLocatorPanel.AutoScroll = true;
        this.FeebasLocatorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.FeebasLocatorPanel.Controls.Add(this.TilePanel);
        this.FeebasLocatorPanel.Location = new System.Drawing.Point(14, 29);
        this.FeebasLocatorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.FeebasLocatorPanel.Name = "FeebasLocatorPanel";
        this.FeebasLocatorPanel.Size = new System.Drawing.Size(233, 115);
        this.FeebasLocatorPanel.TabIndex = 4;
        // 
        // LocationLabel
        // 
        this.LocationLabel.AutoSize = true;
        this.LocationLabel.Location = new System.Drawing.Point(10, 10);
        this.LocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.LocationLabel.Name = "LocationLabel";
        this.LocationLabel.Size = new System.Drawing.Size(0, 15);
        this.LocationLabel.TabIndex = 3;
        // 
        // FeebasSeedLabel
        // 
        this.FeebasSeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.FeebasSeedLabel.AutoSize = true;
        this.FeebasSeedLabel.Location = new System.Drawing.Point(10, 270);
        this.FeebasSeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.FeebasSeedLabel.Name = "FeebasSeedLabel";
        this.FeebasSeedLabel.Size = new System.Drawing.Size(71, 15);
        this.FeebasSeedLabel.TabIndex = 2;
        this.FeebasSeedLabel.Text = TranslationStrings.FeebasSeed;
        // 
        // SaveButton
        // 
        this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.SaveButton.Location = new System.Drawing.Point(230, 262);
        this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.SaveButton.Name = "SaveButton";
        this.SaveButton.Size = new System.Drawing.Size(88, 30);
        this.SaveButton.TabIndex = 1;
        this.SaveButton.Text = TranslationStrings.SaveSeed;
        this.SaveButton.UseVisualStyleBackColor = true;
        this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
        // 
        // FeebasSeedBox
        // 
        this.FeebasSeedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.FeebasSeedBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        this.FeebasSeedBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.FeebasSeedBox.Location = new System.Drawing.Point(99, 267);
        this.FeebasSeedBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.FeebasSeedBox.Name = "FeebasSeedBox";
        this.FeebasSeedBox.Size = new System.Drawing.Size(116, 23);
        this.FeebasSeedBox.TabIndex = 5;
        this.FeebasSeedBox.TextChanged += new System.EventHandler(this.FeebasSeedBox_TextChanged);
        // 
        // FeebasLocatorForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(331, 301);
        this.Controls.Add(this.FeebasSeedBox);
        this.Controls.Add(this.SaveButton);
        this.Controls.Add(this.FeebasSeedLabel);
        this.Controls.Add(this.LocationLabel);
        this.Controls.Add(this.FeebasLocatorPanel);
        this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.MaximizeBox = false;
        this.Name = "FeebasLocatorForm";
        this.ShowIcon = false;
        this.Text = TranslationStrings.PluginName;
        this.FeebasLocatorPanel.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel TilePanel;
    private System.Windows.Forms.Panel FeebasLocatorPanel;
    private System.Windows.Forms.Label LocationLabel;
    private System.Windows.Forms.Label FeebasSeedLabel;
    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.TextBox FeebasSeedBox;
}