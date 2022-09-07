using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static kordamine_oop.koduloom;

namespace kordamine_oop
{
    internal class koer:koduloom
    {
        public string toug;
        public string[] touglist = { "chihuahua", "taksi", "krants", "lablador" };
        public koer(int toug, string nimi, string varv, string loomasugu, double kaal = 0, int vanus = 0, bool elav = false) : base(nimi, varv, loomasugu, kaal, vanus, elav)
        {
            this.toug = touglist[toug];
        }
        public koer(string nimi, string loomasugu) : base(nimi, loomasugu)
        {

        }
        public koer(koer koer_)
        {
            this.toug = koer_.toug;
            this.nimi = koer_.nimi;
            this.vanus = koer_.vanus;
            this.elav = koer_.elav;
            this.kaal = koer_.kaal;
            this.loomasugu = koer_.loomasugu;
        }
        public override void print_haal()
        {
            Console.WriteLine("bark bark");
        }

        public override void print_info()
        {
            Console.WriteLine("Tõug: {0} Värv:{1} Nimi: {2} Sugu: {3} kaal: {4} vanus: {5} ", toug, varv, nimi, loomasugu, kaal, vanus);
        }

    }
}
