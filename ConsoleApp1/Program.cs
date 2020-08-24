using System;

namespace ConsoleApp1
{
    class Obliczanie
    {
        static void Zadanie1(string[] args)
        {
            Console.WriteLine("Liczba liczb w działaniu");
            int i= Convert.ToInt32(Console.ReadLine()); //liczba ile liczb bedzie?
            int wynik = Convert.ToInt32(wynik = 1);
            while (i-- > 0)
            {
                Console.WriteLine("Podaj Liczbe przez która chcesz pomnozyc");
                int liczba1 = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(wynik * liczba1); oups zauwazylem ze to nie do konca dziala
                wynik = wynik * liczba1;
            }
            Console.WriteLine("Wynik to:");
            Console.WriteLine(wynik);
        }
    }
}
   