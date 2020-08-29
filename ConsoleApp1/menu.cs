using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadania
{
    class menu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz numer zadania");
            int zadanie = Convert.ToInt32(Console.ReadLine());
            switch (zadanie)
            {
                case 1:

                    Zadania.Obliczanie.zadanie1(args); // namespace.class.method()

                    break;
                
                case 2:

                    Zadania.Obliczanie2.Zadanie2(args);

                    break;
               
                case 3:

                    Zadania.Obliczanie3.Zadanie3(args);

                    break;
                
                case 4:

                    Zadania.Obliczanie4.zadanie4(args);

                    break;

            }

        }
    }
}
