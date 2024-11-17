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
        TilePanel = new System.Windows.Forms.Panel();
        FeebasLocatorPanel = new System.Windows.Forms.Panel();
        LocationLabel = new System.Windows.Forms.Label();
        FeebasSeedLabel = new System.Windows.Forms.Label();
        SaveButton = new System.Windows.Forms.Button();
        FeebasSeedBox = new System.Windows.Forms.TextBox();
        FeebasLocatorPanel.SuspendLayout();
        SuspendLayout();
        // 
        // TilePanel
        // 
        TilePanel.Location = new System.Drawing.Point(0, 0);
        TilePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        TilePanel.Name = "TilePanel";
        TilePanel.Size = new System.Drawing.Size(233, 115);
        TilePanel.TabIndex = 0;
        // 
        // FeebasLocatorPanel
        // 
        FeebasLocatorPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        FeebasLocatorPanel.AutoScroll = true;
        FeebasLocatorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        FeebasLocatorPanel.Controls.Add(TilePanel);
        FeebasLocatorPanel.Location = new System.Drawing.Point(14, 29);
        FeebasLocatorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        FeebasLocatorPanel.Name = "FeebasLocatorPanel";
        FeebasLocatorPanel.Size = new System.Drawing.Size(233, 115);
        FeebasLocatorPanel.TabIndex = 4;
        // 
        // LocationLabel
        // 
        LocationLabel.AutoSize = true;
        LocationLabel.Location = new System.Drawing.Point(10, 10);
        LocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        LocationLabel.Name = "LocationLabel";
        LocationLabel.Size = new System.Drawing.Size(0, 15);
        LocationLabel.TabIndex = 3;
        // 
        // FeebasSeedLabel
        // 
        FeebasSeedLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        FeebasSeedLabel.AutoSize = true;
        FeebasSeedLabel.Location = new System.Drawing.Point(10, 274);
        FeebasSeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        FeebasSeedLabel.Name = "FeebasSeedLabel";
        FeebasSeedLabel.Size = new System.Drawing.Size(71, 15);
        FeebasSeedLabel.TabIndex = 2;
        FeebasSeedLabel.Text = TranslationStrings.FeebasSeed;
        // 
        // SaveButton
        // 
        SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        SaveButton.Location = new System.Drawing.Point(234, 271);
        SaveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new System.Drawing.Size(84, 22);
        SaveButton.TabIndex = 1;
        SaveButton.Text = TranslationStrings.SaveSeed;
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;
        // 
        // FeebasSeedBox
        // 
        FeebasSeedBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        FeebasSeedBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        FeebasSeedBox.Font = new System.Drawing.Font("Consolas", 9.75F);
        FeebasSeedBox.Location = new System.Drawing.Point(99, 272);
        FeebasSeedBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        FeebasSeedBox.Name = "FeebasSeedBox";
        FeebasSeedBox.Size = new System.Drawing.Size(116, 23);
        FeebasSeedBox.TabIndex = 5;
        FeebasSeedBox.TextChanged += FeebasSeedBox_TextChanged;
        // 
        // FeebasLocatorForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(331, 301);
        Controls.Add(FeebasSeedBox);
        Controls.Add(SaveButton);
        Controls.Add(FeebasSeedLabel);
        Controls.Add(LocationLabel);
        Controls.Add(FeebasLocatorPanel);
        DoubleBuffered = true;
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "FeebasLocatorForm";
        ShowIcon = false;
        Text = TranslationStrings.PluginName;
        FeebasLocatorPanel.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Panel TilePanel;
    private System.Windows.Forms.Panel FeebasLocatorPanel;
    private System.Windows.Forms.Label LocationLabel;
    private System.Windows.Forms.Label FeebasSeedLabel;
    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.TextBox FeebasSeedBox;
}