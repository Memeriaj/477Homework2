using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
        }

        internal void addPlugin(Type type, ExecutionPanel executionPanel)
        {
            if (type.IsSubclassOf(typeof(AbstractPlugin)))
            {
                PluginButton newPluginButton = new PluginButton(type.ToString(), type);
                pluginList.Items.Add(newPluginButton);
                newPluginButton.OpenPlugin += executionPanel.switchPlugin;
            }
        }
    }
}
