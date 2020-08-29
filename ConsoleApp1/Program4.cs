using System;

namespace Zadania
{
    public class Obliczanie4
    {
        public static void Zadanie4(string[] args)
        {
            //Określ ilość liczb w działaniu
            Console.WriteLine("Liczba liczb w działaniu");
            int i = Convert.ToInt32(Console.ReadLine());
            
            //Określ znak
            Console.WriteLine("podaj znak");
            string znak;
            znak = Console.ReadLine();
            if (znak == null)
            {
                Console.WriteLine("Bład: Brak znaku.");
            }

            //Loop
            float wynik = Convert.ToInt32(wynik = 0); //Wynik = 1 działa tylko przy mnożeniu i dzieleniu :( (zad 2)
            while (i-- > 0)
            {
              Console.WriteLine("Podaj Liczbe potrzebna w działaniu");
                //int liczba1 = Convert.ToInt32(Console.ReadLine());
                float liczba1 = float.Parse(Console.ReadLine()); //Dla 3 zadania musiałem tylko zmienić int na Float i Convert.ToInt32 na float.Parse
                switch (znak)
                {
                    case "+":

                        wynik = wynik + liczba1;
                        break;
                    case "-":

                        wynik = wynik - liczba1;
                        break;
                    case "*":

                        if (wynik == 0)
                        {
                            wynik++;
                        }
                        
                        wynik = wynik * liczba1;
                        break;
                    
                    case "/":

                        if (wynik == 0)
                        {
                            wynik++;
                        }
                        if (liczba1 == 0)
                        {
                            Console.WriteLine("Bład: Dzielnie przez 0");
                        }
                        
                        wynik = wynik / liczba1;
                        break;

                     default:                     //default - nie else.
                            Console.WriteLine("Bład: Nie prawidłowy znak. Dostępne znaki: +, -, *, :");
                            break; 
                }


            }
            //Wyświetlenie wyniku
            Console.WriteLine("Wynik to:");
            Console.WriteLine(wynik);
        }
    }
}
   
   