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
//using PluginApp;

namespace TestPlugin
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public Action PostAction {get; set;}

        public UserControl1(Action post)
        {
            InitializeComponent();
            PostAction = post;
        }

        private void postStatus(object sender, RoutedEventArgs e)
        {
            PostAction();
        }
    }
}
