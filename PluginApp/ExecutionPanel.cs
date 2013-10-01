using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginApp
{
    class ExecutionPanel : AbstractPanel
    {
        private List<Type> initializedPlugins = new List<Type>();

        public void switchPlugin(object obj, PluginSelectedEventArgs args)
        {
            if (!initializedPlugins.Contains(args.PluginType))
            {
                // create the plugin and display it
            }
            else
            {
                // find the plugin and display it
            }
        }
    }
}
