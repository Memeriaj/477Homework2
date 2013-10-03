using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginApp;

namespace TestPlugin2
{
    public class TestPlugin2 : AbstractPlugin
    {
        int counter = 0;

        public TestPlugin2()
        {
            Action toPOST = new Action(() => this.OnStatusPosted(" has been relaxing in a sauna for " + counter++ + " minutes"));
            this.Content2 = new UserControl1(toPOST);
        }
    }
}
