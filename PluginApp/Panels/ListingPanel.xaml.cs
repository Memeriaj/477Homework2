using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace PluginApp
{
    /// <summary>
    /// Interaction logic for ListingPanel.xaml
    /// </summary>
    public partial class ListingPanel : UserControl
    {
        public ListingPanel()
        {
            InitializeComponent();
            pluginList.Background = Brushes.LightGreen;
        }

        internal PluginButton addPlugin(Type type)
        {
            PluginButton newPluginButton = new PluginButton(type.ToString(), type);
            pluginList.Items.Add(newPluginButton);
            return newPluginButton;
        }
    }
}
