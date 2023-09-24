using System;
using System.Collections.Generic;
using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using Rhino.Input;
using Rhino.Input.Custom;
using Rhino.PlugIns;
using RhinoPluginTester.Logic.Handlers;
using RhinoPluginTester.View.Forms;

namespace RhinoPluginTester
{
    public class RhinoPluginTesterCommand : Command
    {
        public RhinoPluginTesterCommand()
        {
            // Rhino only creates one instance of each command class defined in a
            // plug-in, so it is safe to store a refence in a static property.
            Instance = this;
        }

        ///<summary>The only instance of this command.</summary>
        public static RhinoPluginTesterCommand Instance
        {
            get; private set;
        }

        ///<returns>The command name as it appears on the Rhino command line.</returns>
        public override string EnglishName
        {
            get { return "RhinoPluginTesterCommand"; }
        }

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {
            string pluginGuid = Properties.Settings.Default.PluginGuid;
            RhinoGet.GetString("Enter plugin Guid (It can be found in Plugin's details at Options > Plugins)", true, ref pluginGuid);

            if (string.IsNullOrWhiteSpace(pluginGuid)) return Result.Cancel;

            SaveCache(pluginGuid);

            List<string> cmds = GetCommandsToTest(pluginGuid);

            RunTests(cmds);

            return Result.Success;
        }

        private void RunTests(List<string> cmds)
        {
            if (cmds.Count == 0) return;
        }

        private List<string> GetCommandsToTest(string pluginGuid)
        {
            PlugInInfo pluginInfo = PlugIn.GetPlugInInfo(new Guid(pluginGuid));
            if (pluginInfo == null) throw new Exception($"Failed to find plugin with Guid '{pluginGuid}' !");

            string[] cmdNames = pluginInfo.CommandNames;

            FormSelectCommands form = new FormSelectCommands(cmdNames);
            form.BringToFront();
            form.ShowDialog();
            return FormSelectCommands.selectedCmdNames;
        }

        private void SaveCache(string pluginGuid)
        {
            Properties.Settings.Default.PluginGuid = pluginGuid;
            Properties.Settings.Default.Save();
        }
    }
}
