using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginApp
{
    class StatusPanel : AbstractPanel
    {
        public void postStatus(object sender, StatusPostedEventArgs args)
        {
            // write args.status to the panel
        }
    }
}
