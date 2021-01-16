using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {   

            Urun urun1 = new Urun();
            urun1.Adi = "Muz";
            urun1.Fiyati = 50;
            urun1.Aciklama = "Maymun muzu";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 50;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2 };


            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");
            }


            Console.WriteLine("Hello World!");
        }
    }
}
