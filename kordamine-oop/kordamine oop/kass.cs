using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine_oop
{
    internal class kass : koduloom
    {
        public string[] loomad_ = new string[] { };
        public string toug;
        public string[] touglist = { "siammis", "sfinks","krants","mainkun" };
        public kass(int toug, string nimi, string varv, string loomasugu, double kaal = 0, int vanus = 0, bool elav = false) : base(nimi, varv, loomasugu, kaal, vanus, elav)
        {
            this.toug = touglist[toug];

        }
        public kass( string nimi,  string loomasugu) : base(nimi,  loomasugu)
        {

        }
        public kass(kass Kass_) 
        {
            this.toug = Kass_.toug;
            this.nimi = Kass_.nimi;
            this.vanus = Kass_.vanus;
            this.elav = Kass_.elav;
            this.kaal = Kass_.kaal;
            this.loomasugu = Kass_.loomasugu;
        }
        public override void print_haal()
        {
            Console.WriteLine("myau purrr");
        }

        public override void print_info()
        {
            Console.WriteLine("Tõug: {0} Värv:{1} Nimi: {2} Sugu: {3} kaal: {4} vanus: {5} ", toug, varv, nimi, loomasugu, kaal, vanus);
        }


    }
}
