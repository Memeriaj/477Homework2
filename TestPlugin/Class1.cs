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
        public Class1()
        {
            this.Content2 = new UserControl1();
        }
    }
}
