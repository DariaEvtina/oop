using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine_oop
{
    abstract class koduloom
    {
        public string nimi;
        public string varv;
        public string loomasugu;
        public double kaal;
        public int vanus;
        public bool elav;
        public koduloom() { }
        public koduloom(string nimi, string varv, string loomasugu, double kaal=0.0, int vanus=0, bool elav=false)
        {
            this.nimi = nimi;
            this.varv = varv;
            this.loomasugu = loomasugu;
            this.kaal = kaal;
            this.vanus = vanus;
            this.elav = elav;
        }
        public koduloom(string nimi, string loomasugu)
        {
            this.nimi = nimi;
            this.loomasugu = loomasugu;
        }
        public abstract void print_haal(); 
        public abstract void print_info();
        public void muudanimi(string uusnimi) { nimi = uusnimi; }

    }
}
