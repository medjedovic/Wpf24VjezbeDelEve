using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf24VjezbeDelEve
{
    public class clsAlarm
    {

        //kreiranje delegata
        public delegate void PromijeniInformacijuHandler(object posiljaoc, clsPromijeniInformacijuArgs a);
        //definisanje delegata
        public event PromijeniInformacijuHandler PromjenaInfo;


        public void PromjenaInfoM(string a)
        {
            PromjenaInfo?.Invoke(this, new clsPromijeniInformacijuArgs(a));
        }
    }
}
