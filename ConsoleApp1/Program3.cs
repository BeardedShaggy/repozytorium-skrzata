using System;

namespace ConsoleApp1
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba liczb w działaniu");
            int i = Convert.ToInt32(Console.ReadLine()); //liczba ile liczb bedzie?
            float wynik = Convert.ToInt32(wynik = 0); //Wynik = 1 działa tylko przy mnożeniu i dzieleniu :( (zad 2)
            while (i-- > 0)
            {
              Console.WriteLine("podaj znak"); 
                string znak;
                znak = Console.ReadLine();
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
                        
                        wynik = wynik / liczba1;
                        break;

                     default:                     //default - nie else.
                            Console.WriteLine("Nie prawidłowy znak");
                            break; 
                }


            }
            Console.WriteLine("Wynik to:");
            Console.WriteLine(wynik);
        }
    }
}
   
   