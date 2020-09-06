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
            const int rows = 3;
            const int columns = 3;

            string[,] array = GetMap(rows, columns);

            int i = 0;
            int z = 0;
            int pos = 0;
            string znak = "";
            while (i < 9) //Dlaczego ja tu wcześniej użyłem if? dunno, don't care.
            {
                i++;
                MapSize(array, rows, columns);
                Console.WriteLine("");
                Console.WriteLine("wybierz numer");
                if (z < 1) //Dla kolka
                {
                    z++;
                    Console.WriteLine("Gracz Kółko");
                    znak = "o";
                    pos = int.Parse(Console.ReadLine());
                }
                else if (z > 0) //Dla krzyzyka
                {
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
                    default:
                        {
                            Console.WriteLine("nie prawidłowa pozycja.");
                            break;
                        }

                        // Dodaj część odczytującą czy są 3 pod rząd kółka/krzyżyki
                        // inaczej dodaj "system" odczytujący czy jest remis
                        // update: zdałem sobie sprawe że trzeba również dodać nie-możliwość zmiany czyjegoś wyboru : D


                }

            }
        }

        private static string[,] GetMap(int rows, int columns)
        {
            string[,] array = new string[rows, columns]; //3 na 3 kratka.
            int value = 1;

            for (int row = 0; row < rows; ++row)
            {
                for (int column = 0; column < columns; ++column)
                {
                    array.SetValue(value.ToString(), row, column);
                    value++;
                }
            }

            return array;
        }
        private static void MapSize(string[,] array, int rows, int columns)
        {

            for (int row = 0; row < rows; ++row)
            {
                Console.WriteLine("");
                for (int column = 0; column < columns; ++column)
                {
                    Console.Write(array[row, column]);
                    Console.Write("|"); 
                }
            }
        }
        //private static string[,]
    }
}
   
   