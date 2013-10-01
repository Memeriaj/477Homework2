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
        private Dictionary<Type, AbstractPlugin> initializedPlugins = new Dictionary<Type, AbstractPlugin>();

        public ExecutionPanel()
        {
            InitializeComponent();
        }

        public void switchPlugin(object obj, PluginSelectedEventArgs args)
        {
            if (!initializedPlugins.ContainsKey(args.PluginType))
            {
                initializedPlugins.Add(args.PluginType, (AbstractPlugin)Activator.CreateInstance(args.PluginType));
                this.Content = initializedPlugins[args.PluginType].Content2;
            }
            else
            {
                this.Content = initializedPlugins[args.PluginType].Content2;
            }

        }
    }
}
