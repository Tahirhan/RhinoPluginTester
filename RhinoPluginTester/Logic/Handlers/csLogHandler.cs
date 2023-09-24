using RhinoPluginTester.View.Forms;
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

        internal static string GetErrorLogState()
        {
            return "";
        }

        internal static string getLogFormat(string cmd, string input, string status, string state)
        {
            if (string.IsNullOrEmpty(state)) return $"Command: {cmd} | Input: {input} | Status: {status} \n\n --- \t --- \t ---";
            return $"Command: {cmd} | Input: {input} | Status: {status} \n\n{state} \n\n --- \t --- \t ---";
        }

        internal static void Msb(string message)
        {
            MessageBox.Show(new Form { StartPosition = FormStartPosition.CenterScreen, TopMost = true }, message, "RhinoPluginTester");
        }
    }
}
