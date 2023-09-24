using Rhino;
using RhinoPluginTester.View.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RhinoPluginTester.Logic.Handlers
{
    internal class csTestHandler
    {
        public static void RunTests(FormTestLogs form, List<string> cmds)
        {
            foreach (string cmd in cmds)
            {
                Type type = typeof(csTestHandler);
                MethodInfo[] methodInfos = type.GetMethods();
                foreach (MethodInfo methodInfo in methodInfos)
                {
                    if (!methodInfo.Name.StartsWith("test_")) continue;
                    string logMessage = methodInfo.Invoke(methodInfo.Name, new object[] { cmd }) as string;

                    form.UpdateLogs(logMessage);
                }
            }
            form.SetAsCompleted();
        }

        public static string test_Empty_Enter(string cmd)
        {
            string initialState = csLogHandler.GetErrorLogState();

            RhinoApp.RunScript($"_-{cmd} Enter", true);

            string recentState = csLogHandler.GetErrorLogState();

            if (initialState != recentState) return csLogHandler.getLogFormat(cmd, "Empty", "Crashed", recentState);
            else return csLogHandler.getLogFormat(cmd, "Empty", "Successful", null);
        }
    }
}
