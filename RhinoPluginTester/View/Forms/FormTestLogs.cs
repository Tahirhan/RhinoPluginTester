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
    public partial class FormTestLogs : Form
    {
        public FormTestLogs()
        {
            InitializeComponent();
        }

        internal void SetAsCompleted()
        {
            lblStatus.Text = "All tests applied.";
        }

        internal void UpdateLogs(string logMessage)
        {
            rtbLogs.Text += $"\n[{DateTime.Now.ToShortTimeString()}] " + logMessage;
            this.Refresh();
        }

        private void FormTestLogs_Load(object sender, EventArgs e)
        {

        }
    }
}
