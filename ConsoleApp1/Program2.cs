using System;

namespace ConsoleApp1
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba liczb w działaniu");
            int i = Convert.ToInt32(Console.ReadLine()); //liczba ile liczb bedzie?
            int wynik = Convert.ToInt32(wynik = 0); //Wynik = 1 działa tylko przy mnożeniu :(
            while (i-- > 0)
            {
              Console.WriteLine("podaj znak"); 
                string znak;
                znak = Console.ReadLine();
              Console.WriteLine("Podaj Liczbe potrzebna w działaniu");
                int liczba1 = Convert.ToInt32(Console.ReadLine());

                switch (znak)
                {
                    case "+":
                        wynik = wynik + liczba1;
                        break;
                    case "-":
                        wynik = wynik - liczba1;
                        break;
                    case "*":

                        if (wynik == 0) //nie prawidłowo zrobione
                        {
                            wynik++;
                        }

                        wynik = wynik * liczba1;
                        break;
                    case "/":

                        if (wynik == 0) //nie prawidłowo zrobione
                        {
                            wynik++;
                        }
                        wynik = wynik / liczba1;
                        break;
                        /*else:                       //do poprawy
                            Console.WriteLine("nie prawidłowy znak");
                            break; */
                }
                //Console.WriteLine(wynik * liczba1); oups zauwazylem ze to nie do konca dziala


            }
            Console.WriteLine("Wynik to:");
            Console.WriteLine(wynik);
        }
    }
}
   
   