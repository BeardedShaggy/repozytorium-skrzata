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
            array.SetValue("1", 0, 0);
            array.SetValue("2", 0, 1);
            array.SetValue("3", 0, 2);
            array.SetValue("4", 1, 0);
            array.SetValue("5", 1, 1);
            array.SetValue("6", 1, 2);
            array.SetValue("7", 2, 0);
            array.SetValue("8", 2, 1);
            array.SetValue("9", 2, 2);
            Console.WriteLine("wybierz numer");
            int i = Convert.ToInt32(i = 0); int z = Convert.ToInt32(z = 0); int pos = Convert.ToInt32(pos = 0)
            string znak = "";
            if (i < 9, i++)
            {
                if (z < 1, z++) //Dla kolka
                {
                    Console.WriteLine("Gracz Kółko");
                    znak = "o";
                }
                else if (z > 0, z--) //Dla krzyzyka
                {
                    Console.WriteLine("Gracz krzyżyk");
                    znak = "x";

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
                }
            }
        }
    }
}
   
   