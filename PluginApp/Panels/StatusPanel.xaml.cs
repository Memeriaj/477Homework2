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
    /// Interaction logic for StatusPanel.xaml
    /// </summary>
    public partial class StatusPanel : UserControl
    {
        public StatusPanel()
        {
            InitializeComponent();
        }

        public void postStatus(object sender, StatusPostedEventArgs args)
        {
            statusBox.Text = statusBox.Text + "\n" + args.Status;
        }
    }
}
