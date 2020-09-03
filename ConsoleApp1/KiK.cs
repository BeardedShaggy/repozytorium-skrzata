using System;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Zadania
{
    public class TicToe
    {
        public static void TicToeGame(string[] args)
        {

            string[,] array = new string[3, 3]; //3 na 3 kratka.
            array.SetValue("1", 0, 0);
            array.SetValue("2", 0, 1);
            array.SetValue("3", 0, 2);
            array.SetValue("4", 1, 0);
            array.SetValue("5", 1, 1);
            array.SetValue("6", 1, 2);
            array.SetValue("7", 2, 0);
            array.SetValue("8", 2, 1);
            array.SetValue("9", 2, 2);

            System.Console.WriteLine("");
                System.Console.Write(array[0, 0]);//1
            System.Console.Write("|");
                System.Console.Write(array[0, 1]);//2
            System.Console.Write("|");
                System.Console.Write(array[0, 2]);//3
                System.Console.WriteLine("");
                System.Console.Write(array[1, 0]);//4
            System.Console.Write("|");
                System.Console.Write(array[1, 1]);//5
            System.Console.Write("|");
                System.Console.Write(array[1, 2]);//6
                System.Console.WriteLine("");
                System.Console.Write(array[2, 0]);//7
            System.Console.Write("|");
                System.Console.Write(array[2, 1]);//8
            System.Console.Write("|");
                System.Console.Write(array[2, 2]);//9
            System.Console.WriteLine("");
            System.Console.WriteLine("wybierz numer");
            int i = Convert.ToInt32(i = 0); int z = Convert.ToInt32(z = 0); int pos = Convert.ToInt32(pos = 0);
            string znak = "";
            if (i < 9)
            {
                System.Console.WriteLine("");
                System.Console.Write(array[0, 0]);//1
                System.Console.Write("|");
                System.Console.Write(array[0, 1]);//2
                System.Console.Write("|");
                System.Console.Write(array[0, 2]);//3
                System.Console.WriteLine("");
                System.Console.Write(array[1, 0]);//4
                System.Console.Write("|");
                System.Console.Write(array[1, 1]);//5
                System.Console.Write("|");
                System.Console.Write(array[1, 2]);//6
                System.Console.WriteLine("");
                System.Console.Write(array[2, 0]);//7
                System.Console.Write("|");
                System.Console.Write(array[2, 1]);//8
                System.Console.Write("|");
                System.Console.Write(array[2, 2]);//9
                System.Console.WriteLine("");
                System.Console.WriteLine("wybierz numer");
                if (z < 1) //Dla kolka
                {
                    i++;
                    z++;
                    Console.WriteLine("Gracz Kółko");
                    znak = "o";
                    pos = int.Parse(Console.ReadLine());
                    //Console.ReadLine(pos); nie działa
                    // Dodaj odczytywanie pozyczji z switch(pos)
                }
                else if (z > 0) //Dla krzyzyka
                {
                    i++;
                    z--;
                    Console.WriteLine("Gracz krzyżyk");
                    znak = "x";
                    pos = int.Parse(Console.ReadLine());
                    // Dodaj odczytywanie pozycji z Switch(Pos)

                }
                switch (pos)
                {
                    case 1:
                        {
                            array.SetValue(znak, 0, 0);
                            break;
                        }
                    case 2:
                        {
                            array.SetValue(znak, 0, 1);
                            break;
                        }
                    case 3:
                        {
                            array.SetValue(znak, 0, 2);
                            break;
                        }
                    case 4:
                        {
                            array.SetValue(znak, 1, 0);
                            break;
                        }
                    case 5:
                        {
                            array.SetValue(znak, 1, 1);
                            break;
                        }
                    case 6:
                        {
                            array.SetValue(znak, 1, 2);
                            break;
                        }
                    case 7:
                        {
                            array.SetValue(znak, 2, 0);
                            break;
                        }
                    case 8:
                        {
                            array.SetValue(znak, 2, 1);
                            break;
                        }
                    case 9:
                        {
                            array.SetValue(znak, 2, 2);
                            break;
                        }
                        // Dodaj część odczytującą czy są 3 pod rząd kółka/krzyżyki
                        // inaczej dodaj "system" odczytujący czy jest remis


                }

            }
        }
    }
}
   
   