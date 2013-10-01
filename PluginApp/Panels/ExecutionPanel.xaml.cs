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
    /// Interaction logic for ExecutionPanel.xaml
    /// </summary>
    public partial class ExecutionPanel : UserControl
    {
        private List<Type> initializedPlugins = new List<Type>();

        public ExecutionPanel()
        {
            InitializeComponent();
        }

        public void switchPlugin(object obj, PluginSelectedEventArgs args)
        {
            if (!initializedPlugins.Contains(args.PluginType))
            {
                // create the plugin and display it
            }
            else
            {
                // find the plugin and display it
            }
        }
    }
}
