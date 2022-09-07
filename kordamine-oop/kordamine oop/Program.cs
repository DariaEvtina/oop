// See https://aka.ms/new-console-template for more information
using kordamine_oop;
using System.Numerics;
internal class Program
{
    private static void Main(string[] args)
    {
        List<kass> listkass = new List<kass>();
        List<koer> listkoer = new List<koer>();
        kass Kass_ = new kass(1, "sarik", "sinine", "emane", 5.5, 7, true);
        Kass_.print_info();
        Kass_.print_haal();
        listkass.Add(Kass_);
        Console.ReadLine();
        kass Kass_1 = new kass(3, "julia", "must", "emane", 5.5, 7, true);
        Kass_1.print_info();
        Kass_1.print_haal();
        listkass.Add(Kass_1);
        Console.ReadLine();
        koer koer_ = new koer(0, "puk", "kolane", "isane", 35.5, 2, true);
        koer_.print_info();
        koer_.print_haal();
        listkoer.Add(koer_);
        Console.ReadLine();
        using (StreamWriter sw = new StreamWriter(@"..\..\..\koduloomad.txt"))
        {
            sw.WriteLine("====KASS====\n");
            foreach (kass kass_2 in listkass)
            {

                sw.WriteLine($"Tõug: {kass_2.toug} Värv: {kass_2.varv} Nimi: {kass_2.nimi} Sugu: {kass_2.loomasugu} Kaal: {kass_2.kaal} Vanus: {kass_2.vanus}\n");

            }
            sw.WriteLine("====KASS====\n");
            sw.WriteLine("====KOER====\n");
            foreach (koer koer_2 in listkoer)
            {
                sw.WriteLine($"Tõug: {koer_2.toug} Värv: {koer_2.varv} Nimi: {koer_2.nimi} Sugu: {koer_2.loomasugu} Kaal: {koer_2.kaal} Vanus: {koer_2.vanus}\n");
            }
            sw.WriteLine("====KOER====");
            sw.Close();
        }
        using (StreamWriter sw = new StreamWriter(@"..\..\..\baskassid.txt"))
        {
            foreach (kass kass_2 in listkass)
            {
                sw.WriteLine($"{kass_2.nimi},{kass_2.loomasugu}.");

            }
            sw.WriteLine("!");
            sw.Close();
        }
        using (StreamWriter sw = new StreamWriter(@"..\..\..\baskoerad.txt"))
        {
            foreach (koer koer_2 in listkoer)
            {
                sw.WriteLine($"{koer_2.nimi},{koer_2.loomasugu}.");
            }
            sw.WriteLine("!");
            sw.Close();
        }
        Console.WriteLine("data lisad");
        Console.ReadLine();
        List<kass> kassid = new List<kass>();
        string text;
        using (StreamReader sr = new StreamReader(@"..\..\..\baskassid.txt"))
        {
            while (sr.ReadLine()=="!")
            {
                if (sr.ReadLine() != "\n" || sr.ReadLine() != null)
                {
                    text = sr.ReadLine();
                    string[] rida = text.Split(',');
                    kassid.Add(new kass(rida[0], rida[1]));
                }
            }
            sr.Close();
        }


        List<koer> koerid = new List<koer>();
        using (StreamReader sr1 = new StreamReader(@"..\..\..\baskoerad.txt")) 
        {
            while (sr1.ReadLine() == "!")
            {
                if (sr1.ReadLine()!="\n")
                {
                    text = sr1.ReadLine();
                    string[] rida = text.Split(',');
                    koerid.Add(new koer(rida[0], rida[1]));
                }
                
            }
            sr1.Close();
        }
        Console.ReadLine();
        foreach (kass item in kassid)
        {
            Console.WriteLine(item.nimi + " " + item.loomasugu );
        }
        foreach (koer item in koerid)
        {
            Console.WriteLine(item.nimi + " " + item.loomasugu );
        }
        Console.ReadLine();
    }
}