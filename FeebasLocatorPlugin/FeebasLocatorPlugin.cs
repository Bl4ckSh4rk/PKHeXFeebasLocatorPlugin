using System;
using System.Windows.Forms;
using PKHeX.Core;

namespace FeebasLocatorPlugin;

public class FeebasLocator : IPlugin
{
    public string Name => nameof(FeebasLocator);
    public int Priority => 1; // Loading order, lowest is first.
    public ISaveFileProvider SaveFileEditor { get; private set; } = null!;

    private ToolStripMenuItem ctrl = new();

    public void Initialize(params object[] args)
    {
        LocalizationUtil.SetLocalization(GameInfo.CurrentLanguage);

        Console.WriteLine($"Loading {Name}...");
        SaveFileEditor = (ISaveFileProvider)Array.Find(args, z => z is ISaveFileProvider)!;
        LoadMenuStrip((ToolStrip?)Array.Find(args, z => z is ToolStrip));

    }

    private void LoadMenuStrip(ToolStrip? menuStrip)
    {
        AddPluginControl((ToolStripDropDownItem?)menuStrip?.Items.Find("Menu_Tools", false)[0]);
    }

    private void AddPluginControl(ToolStripDropDownItem? tools)
    {
        ctrl = new ToolStripMenuItem()
        {
            Visible = false,
            Image = Properties.Resources.icon
        };

        ctrl.Click += new EventHandler(OpenFeebasLocatorForm);
        _ = (tools?.DropDownItems.Add(ctrl));

        NotifyDisplayLanguageChanged(GameInfo.CurrentLanguage);
    }

    private void OpenFeebasLocatorForm(object? sender, EventArgs? e)
    {
        _ = new FeebasLocatorForm(SaveFileEditor.SAV).ShowDialog();
    }

    public void NotifySaveLoaded()
    {
        if (ctrl != null)
            ctrl.Visible = SaveFileEditor.SAV is IGen3Hoenn or SAV4Sinnoh or SAV8BS;
    }

    public void NotifyDisplayLanguageChanged(string language)
    {
        LocalizationUtil.SetLocalization(language);

        ctrl.Text = TranslationStrings.PluginName;
    }

    public bool TryLoadFile(string filePath) => false;
}
