using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginApp
{
    class PluginSelectedEventArgs : EventArgs
    {
        public AbstractPlugin Plugin { get; set; }

        public PluginSelectedEventArgs(AbstractPlugin plugin)
        {
            Plugin = plugin;
        }
    }

    class StatusPostedEventArgs : EventArgs
    {
        public string Status { get; set; }

        public StatusPostedEventArgs(string status)
        {
            Status = status;
        }
    }
}
