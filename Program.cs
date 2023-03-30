using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string szukanyZnak = "°";
            string znakKoncowy = ">";

            while (true)
            {
                Console.WriteLine("Podaj nazwe miasta");
                string miasto = Console.ReadLine();
                string adres = $"https://www.google.com/search?q=pogoda {miasto}";

                WebClient wc = new WebClient();
                string dane = wc.DownloadString(adres);

                int indx = dane.IndexOf(szukanyZnak);
                int aktualnaPozycja = indx;

                while (dane.Substring(aktualnaPozycja, 1) != znakKoncowy)
                    aktualnaPozycja--;

                string wynik = dane.Substring(aktualnaPozycja + 1, indx - aktualnaPozycja + 1);

                Console.WriteLine(wynik);
            }


            Console.ReadKey();

        }
    }
}
