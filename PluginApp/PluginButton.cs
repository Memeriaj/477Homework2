using System;
using System.Windows.Controls;

namespace PluginApp
{
    public class PluginButton : Button
    {
        private Type pluginType;
        public event EventHandler<PluginSelectedEventArgs> OpenPlugin;

        public PluginButton(string name, Type pluginType)
        {
            this.Content = name;
            this.pluginType = pluginType;
        }

        protected override void OnClick()
        {
            if (null != OpenPlugin)
            {
                OpenPlugin(this, new PluginSelectedEventArgs(pluginType));
            }
        }
    }
}
