﻿using System;

namespace Zadania
{
    public class Obliczanie2
    {
        public static void Zadanie2(string[] args)
        {
            Console.WriteLine("Liczba liczb w działaniu");
            int i = Convert.ToInt32(Console.ReadLine()); //liczba ile liczb bedzie?
            int wynik = Convert.ToInt32(wynik = 0); //Wynik = 1 działa tylko przy mnożeniu i dzieleniu :(
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
                //Console.WriteLine(wynik * liczba1); oups zauwazylem ze to nie do konca dziala


            }
            Console.WriteLine("Wynik to:");
            Console.WriteLine(wynik);
        }
    }
}
   
   