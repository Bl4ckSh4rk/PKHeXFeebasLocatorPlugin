﻿using System;
using System.Windows.Forms;
using PKHeX.Core;

namespace FeebasLocatorPlugin
{
    public class FeebasLocator : IPlugin
    {
        public string Name => "Feebas Locator";
        public int Priority => 1; // Loading order, lowest is first.
        public ISaveFileProvider SaveFileEditor { get; private set; }
        public IPKMView PKMEditor { get; private set; }

        public void Initialize(params object[] args)
        {
            Console.WriteLine($"Loading {Name}...");
            if (args == null)
                return;
            SaveFileEditor = (ISaveFileProvider)Array.Find(args, z => z is ISaveFileProvider);
            PKMEditor = (IPKMView)Array.Find(args, z => z is IPKMView);
            var menu = (ToolStrip)Array.Find(args, z => z is ToolStrip);
            LoadMenuStrip(menu);
        }

        private void LoadMenuStrip(ToolStrip menuStrip)
        {
            var items = menuStrip.Items;
            var tools = items.Find("Menu_Tools", false)[0] as ToolStripDropDownItem;
            AddPluginControl(tools);
        }

        private void AddPluginControl(ToolStripDropDownItem tools)
        {
            var ctrl = new ToolStripMenuItem(Name);
            tools.DropDownItems.Add(ctrl);
            ctrl.Image = Properties.Resources.icon;
            ctrl.Click += new EventHandler(OpenFeebasLocatorForm);
        }

        private void OpenFeebasLocatorForm(object sender, EventArgs e)
        {
            switch (SaveFileEditor.SAV.Version)
            {
                case GameVersion.S:
                case GameVersion.R:
                case GameVersion.E:
                case GameVersion.D:
                case GameVersion.P:
                case GameVersion.Pt:
                case GameVersion.RS:
                case GameVersion.RSE:
                case GameVersion.DP:
                case GameVersion.DPPt:
                    new FeebasLocatorForm(SaveFileEditor.SAV).ShowDialog();
                    break;
                default:
                    MessageBox.Show("Feebas Locator is only available for Ruby, Sapphire and Emerald as well as Diamond, Pearl and Platinum.", "Error");
                    break;
            }
        }

        public void NotifySaveLoaded()
        {
            Console.WriteLine($"{Name} was notified that a Save File was just loaded.");
        }
        public bool TryLoadFile(string filePath)
        {
            Console.WriteLine($"{Name} was provided with the file path, but chose to do nothing with it.");
            return false; // no action taken
        }
    }
}
