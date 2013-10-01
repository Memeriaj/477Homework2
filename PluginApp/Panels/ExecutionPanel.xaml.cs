using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;

namespace PluginApp
{
    /// <summary>
    /// Interaction logic for ExecutionPanel.xaml
    /// </summary>
    public partial class ExecutionPanel : UserControl
    {
        private Dictionary<Type, AbstractPlugin> initializedPlugins = new Dictionary<Type, AbstractPlugin>();

        public ExecutionPanel()
        {
            InitializeComponent();
            this.Background = Brushes.LightSkyBlue;
        }

        public void addPlugin(AbstractPlugin pluginToAdd)
        {
            initializedPlugins.Add(pluginToAdd.GetType(), pluginToAdd);
        }

        public void switchPlugin(object obj, PluginSelectedEventArgs args)
        {
            this.Content = initializedPlugins[args.PluginType].Content2;
        }
    }
}
