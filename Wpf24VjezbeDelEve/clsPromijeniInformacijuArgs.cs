using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf24VjezbeDelEve
{
    public class clsPromijeniInformacijuArgs
    {
        public string info { get; set; }

        public clsPromijeniInformacijuArgs() { }


        public clsPromijeniInformacijuArgs(string g) 
        {
            info = g;
        }
    }
}
