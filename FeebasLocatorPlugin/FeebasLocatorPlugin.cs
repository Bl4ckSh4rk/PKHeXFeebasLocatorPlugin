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
            LoadMenuStrip((ToolStrip)Array.Find(args, z => z is ToolStrip));
        }

        private void LoadMenuStrip(ToolStrip menuStrip)
        {
            AddPluginControl((ToolStripDropDownItem)menuStrip.Items.Find("Menu_Tools", false)[0]);
        }

        private void AddPluginControl(ToolStripDropDownItem tools)
        {
            ctrl = new ToolStripMenuItem(Name)
            {
                Visible = false,
                Image = Properties.Resources.icon
            };
            ctrl.Click += new EventHandler(OpenFeebasLocatorForm);
            tools.DropDownItems.Add(ctrl);
        }

        private void OpenFeebasLocatorForm(object sender, EventArgs e)
        {
            _ = new FeebasLocatorForm(SaveFileEditor.SAV).ShowDialog();
        }

        public void NotifySaveLoaded()
        {
            if (ctrl != null)
                ctrl.Visible = SaveFileEditor.SAV is SAV3RS or SAV3E or SAV4DP or SAV4Pt;
        }

        public bool TryLoadFile(string filePath) => false;
    }
}
