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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StatusPanel statusPanel = new StatusPanel();
        private ListingPanel listingPanel = new ListingPanel();
        private ExecutionPanel executionPanel = new ExecutionPanel();

        public MainWindow()
        {
            InitializeComponent();
            // grab all the types from the dlls
            // create a PluginButton for each of the dlls and add them to the listing panel
            // for each PluginButton, PluginButton.OpenPlugin += executionPanel.switchPlugin
        }
    }
}
