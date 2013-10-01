using System;
using System.Windows.Controls;

namespace PluginApp
{
    public abstract class AbstractPlugin
    {
        public event EventHandler<StatusPostedEventArgs> StatusPosted;
        public Panel Content { get; }

        protected void OnStatusPosted(string status)
        {
            if (null != StatusPosted)
            {
                StatusPosted(this, new StatusPostedEventArgs(status));
            }
        }
    }
}
