using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginApp
{
    abstract class AbstractPlugin : AbstractPanel
    {
        public event EventHandler<StatusPostedEventArgs> StatusPosted;

        protected void OnStatusPosted(string status)
        {
            if (null != StatusPosted)
            {
                StatusPosted(this, new StatusPostedEventArgs(status));
            }
        }
    }
}
