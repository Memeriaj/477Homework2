using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginApp;

namespace TestPlugin
{
    public class Class1 : AbstractPlugin
    {
        int counter = 0;

        public Class1()
        {
            Action toPOST = new Action(() => this.OnStatusPosted("Hello Status" + counter++));
            this.Content2 = new UserControl1(toPOST);
        }


    }
}
