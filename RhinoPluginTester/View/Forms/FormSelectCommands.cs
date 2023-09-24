using Rhino.Commands;
using RhinoPluginTester.Logic.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhinoPluginTester.View.Forms
{
    public partial class FormSelectCommands : Form
    {
        internal static List<string> selectedCmdNames;
        string[] cmdNames;

        public FormSelectCommands(string[] _cmdNames)
        {
            InitializeComponent();
            cmdNames = _cmdNames;
        }

        private void FormSelectCommands_Load(object sender, EventArgs e)
        {
            selectedCmdNames = new List<string>();
            clbCommands.Items.Clear();
            clbCommands.Items.AddRange(cmdNames as object[]);

            // Changes the selection mode from double-click to single click.
            clbCommands.CheckOnClick = true;
        }

        private void btnRunTests_Click(object sender, EventArgs e)
        {
            if (clbCommands.SelectedItems.Count == 0) { csLogHandler.Msb("Please select a command from the list!"); return; }

            DialogResult dialogResult = csLogHandler.Ask("Running some commands may cause not recoverable problems! Are you sure to test selected commands?");
            if (dialogResult != DialogResult.Yes) return;

            List<string> checkedCmdNames = new List<string>();
            foreach (var item in clbCommands.CheckedItems)
            {
                checkedCmdNames.Add(item as string);   
            }
            selectedCmdNames = cmdNames.Where(r => checkedCmdNames.Contains(r)).ToList();

            Close();
        }
    }
}
