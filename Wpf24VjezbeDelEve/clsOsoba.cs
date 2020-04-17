using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf24VjezbeDelEve
{
    public class clsOsoba : INotifyPropertyChanged
    {
        public string ime { get; set; }
        public string prezime { get; set; }

        private string i;
        public string info 
        {
            get => i;
                
            set
            {
                i = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("info"));
            }
        }

        public clsOsoba() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i">Vrijednost za ime</param>
        /// <param name="p">Vrijednost za prezime</param>
        /// <param name="inf">Vrijednost za informaciju</param>
        public clsOsoba(string i, string p, string inf) 
        {
            ime = i;
            prezime = p;
            info = inf;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void PromjenaInformacije(object posiljaoc, clsPromijeniInformacijuArgs a)
        {
            info = a.info;
        }
    }
}
