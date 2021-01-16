using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici";
            string kurs2 = "Temel Kamp";



            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici",
                "Temel Kamp",
                "Bambaşka Kamp"
            };



            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            Console.WriteLine("For bitti");


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
