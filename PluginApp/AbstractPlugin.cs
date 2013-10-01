using System;
using System.Windows.Controls;

namespace PluginApp
{
    public abstract class AbstractPlugin : Panel
    {
        public event EventHandler<StatusPostedEventArgs> StatusPosted;
        public UserControl Content2 { get; set; }

        protected void OnStatusPosted(string status)
        {
            if (null != StatusPosted)
            {
                StatusPosted(this, new StatusPostedEventArgs(status));
            }
        }
    }
}
