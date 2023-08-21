using System;

namespace YhteenlaskuOhjelma
{
    class Program
    {
        static double Yhteenlasku(double a, double b)
        {
            // Laskee kaksi lukua yhteen ja palauttaa tuloksen
            double summa = a + b;
            return summa;
        }

        static void Main(string[] args)
        {
            Console.Write("Syötä ensimmäinen luku: ");
            double luku1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Syötä toinen luku: ");
            double luku2 = Convert.ToDouble(Console.ReadLine());

            // Kutsutaan Yhteenlasku-funktiota ja tulostetaan tulos
            double tulos = Yhteenlasku(luku1, luku2);
            Console.WriteLine("Tuloksena on: " + tulos);
        }
    }
}

