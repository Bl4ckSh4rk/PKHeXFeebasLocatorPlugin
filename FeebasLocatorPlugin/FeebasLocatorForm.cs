using System;
using System.Drawing;
using System.Windows.Forms;
using PKHeX.Core;

namespace FeebasLocatorPlugin;

public partial class FeebasLocatorForm : Form
{
    private const int SEED_OFFSET_RS = 0x2DD6;
    private const int SEED_OFFSET_E = 0x2E6A;
    private const int SEED_OFFSET_DP = 0x53C8;
    private const int SEED_OFFSET_PT = 0x5664;
    private const int SEED_WORK_BS = 436;

    private readonly SaveFile Save;
    private readonly int SeedOffset;
    private readonly FeebasMap? Map;

    public FeebasLocatorForm(SaveFile sav)
    {
        InitializeComponent();
        Save = sav;

        Map = new(Save.Generation)
        {
            Location = new(0, 0)
        };
        FeebasLocatorPanel.Controls.Add(Map);

        MaximumSize = Save.Generation == 3 ? new Size(703, 1000) : new Size(573, 641);
        MinimumSize = Save.Generation == 3 ? new Size(703, 600) : new Size(573, 641);

        if (Save is SAV3 s3)
        {
            SeedOffset = Save is SAV3RS ? SEED_OFFSET_RS : SEED_OFFSET_E;
            Map.UpdateSeed(BitConverter.ToUInt16(s3.Large[SeedOffset..]));
        }
        else if (Save is SAV4Sinnoh s4)
        {
            SeedOffset = Save is SAV4DP ? SEED_OFFSET_DP : SEED_OFFSET_PT;
            Map.UpdateSeed(BitConverter.ToUInt32(s4.General[SeedOffset..]));
        }
        else if (Save is SAV8BS s8)
        {
            SeedOffset = SEED_WORK_BS;
            Map.UpdateSeed((uint)s8.GetWork(SeedOffset));
        }

        FeebasSeedBox.MaxLength = Save.Generation == 3 ? 4 : 8;
        FeebasSeedBox.Text = Map.Seed.ToString("X");
        LocationLabel.Text = Save.Generation == 3 ? TranslationStrings.Route119 : TranslationStrings.MtCoronet;

        LoadTranslations();
    }

    private void FeebasSeedBox_TextChanged(object sender, EventArgs e)
    {
        if (FeebasSeedBox.Text.Length < 1)
            return;
        Map?.UpdateSeed(Util.GetHexValue(FeebasSeedBox.Text));
    }

    private void FeebasSeedBox_KeyPressed(object sender, KeyPressEventArgs e)
    {
        char ch = e.KeyChar;
        if (char.IsControl(ch))
            return;
        if (!Uri.IsHexDigit(ch))
            e.Handled = true;
        else
            e.KeyChar = char.ToUpper(ch);
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (FeebasSeedBox.Text != "")
        {
            if (Save is SAV3 s3)
                BitConverter.GetBytes(Util.GetHexValue(FeebasSeedBox.Text)).CopyTo(s3.Large[SeedOffset..]);
            else if (Save is SAV4Sinnoh s4)
                BitConverter.GetBytes(Util.GetHexValue(FeebasSeedBox.Text)).CopyTo(s4.General[SeedOffset..]);
            else if (Save is SAV8BS s8)
                s8.SetWork(SeedOffset, (int)Util.GetHexValue(FeebasSeedBox.Text));

            Save.State.Edited = true;
        }
        Close();
    }

    private void LoadTranslations()
    {
        Text = TranslationStrings.PluginName;
        LocationLabel.Text = Save.Generation == 3 ? TranslationStrings.Route119 : TranslationStrings.MtCoronet;
        FeebasSeedLabel.Text = TranslationStrings.FeebasSeed;
        SaveButton.Text = TranslationStrings.SaveSeed;
    }
}
