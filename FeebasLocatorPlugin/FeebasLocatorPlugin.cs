using System;
using System.Windows.Forms;
using PKHeX.Core;

namespace FeebasLocatorPlugin
{
    public class FeebasLocator : IPlugin
    {
        public string Name => "Feebas Locator";
        public int Priority => 1; // Loading order, lowest is first.
        public ISaveFileProvider SaveFileEditor { get; private set; } = null!;
        public IPKMView PKMEditor { get; private set; } = null!;

        private ToolStripMenuItem? ctrl;

        public void Initialize(params object[] args)
        {
            Console.WriteLine($"Loading {Name}...");
            SaveFileEditor = (ISaveFileProvider)Array.Find(args, z => z is ISaveFileProvider)!;
            PKMEditor = (IPKMView)Array.Find(args, z => z is IPKMView)!;
            var menu = (ToolStrip)Array.Find(args, z => z is ToolStrip);
            LoadMenuStrip(menu);
        }

        private void LoadMenuStrip(ToolStrip menuStrip)
        {
            var items = menuStrip.Items;
            var tools = (ToolStripDropDownItem) items.Find("Menu_Tools", false)[0];
            AddPluginControl(tools);
        }

        private void AddPluginControl(ToolStripDropDownItem tools)
        {
            ctrl = new ToolStripMenuItem(Name);
            tools.DropDownItems.Add(ctrl);
            ctrl.Image = Properties.Resources.icon;
            ctrl.Click += new EventHandler(OpenFeebasLocatorForm);
            ctrl.Enabled = false;
        }

        private void OpenFeebasLocatorForm(object sender, EventArgs e)
        {
            _ = new FeebasLocatorForm(SaveFileEditor.SAV).ShowDialog();
        }

        public void NotifySaveLoaded()
        {
            if (ctrl != null)
                ctrl.Enabled = SaveFileEditor.SAV is SAV3RS or SAV3E or SAV4DP or SAV4Pt;
        }
        public bool TryLoadFile(string filePath)
        {
            Console.WriteLine($"{Name} was provided with the file path, but chose to do nothing with it.");
            return false; // no action taken
        }
    }
}
