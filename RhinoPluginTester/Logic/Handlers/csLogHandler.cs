using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhinoPluginTester.Logic.Handlers
{
    internal class csLogHandler
    {
        internal static DialogResult Ask(string question)
        {
            return MessageBox.Show(new Form { StartPosition = FormStartPosition.CenterScreen, TopMost = true }, question, "RhinoPluginTester", MessageBoxButtons.YesNo);
        }

        internal static void Msb(string message)
        {
            MessageBox.Show(new Form { StartPosition = FormStartPosition.CenterScreen, TopMost = true }, message, "RhinoPluginTester");
        }
    }
}
