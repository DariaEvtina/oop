using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine_oop
{
    internal class pig : kodulomad2
    {
        string nimi;
        float kaal;
        float kehapikkus;
        float rinna;
        string sugu;
        public pig() { }
        public pig(string nimi, float kaal, float kehapikkus, float rinna, string sugu) 
        { 
            this.nimi = nimi;
            this.kaal = kaal;   
            this.kehapikkus = kehapikkus;   
            this.rinna = rinna;
            this.sugu = sugu;
        }
        public void Mistoug()
        {

        }
    }
}
