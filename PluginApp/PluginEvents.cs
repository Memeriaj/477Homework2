using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginApp
{
    public class PluginSelectedEventArgs : EventArgs
    {
        public Type PluginType { get; set; }

        public PluginSelectedEventArgs(Type pluginType)
        {
            PluginType = pluginType;
        }
    }

    public class StatusPostedEventArgs : EventArgs
    {
        public string Status { get; set; }

        public StatusPostedEventArgs(string status)
        {
            Status = status;
        }
    }
}
