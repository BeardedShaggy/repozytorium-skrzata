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
            int row = 0;
            //int pos = 0;
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
                }
                else if (z > 0) //Dla krzyzyka
                {
                    z--;
                    Console.WriteLine("Gracz krzyżyk");
                    znak = "x";
                }

                string valueToFind = string.Empty;

                do
                {
                    Console.WriteLine("Dawaj wartoswc");

                    valueToFind = Console.ReadLine();
                }
                while (!CheckValue(array, rows, columns, valueToFind, znak)); // to samo co: while (CheckValue(array, rows, columns, valueToFind, znak) != true); 
                bool result = CheckO(array, columns, row, valueToFind);
                if (result == true)
                {
                    return;
                }
                result = CheckX(array, columns, row, valueToFind);
                if (result == true)
                {
                    return;
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

        private static bool CheckValue(string[,] array, int rows, int columns, string valueToFind, string character)
        {

            for (int row = 0; row < rows; ++row)
            {
                for (int column = 0; column < columns; ++column)
                {
                    if (array[row, column] == valueToFind)
                    {
                        array[row, column] = character;
                        return true;
                    }
                }
            }
            return false;
        }
        private static bool CheckX(string[,] array, int columns, int row, string valuesToCheck)
        {
            for (int column = 0; column < columns; ++column)
            {
                if (array[row, column] != "x")
                {
                    return false;
                }
            }
            Console.WriteLine("SUKCES");
            return true;
        }

        private static bool CheckO(string[,] array, int columns, int row, string valuesToCheck)
            { 
            for (int column = 0; column < columns; ++column)
            {
                if (array[row, column] != "o")
                {
                    return false;
                }
            }
            Console.WriteLine("SUKCES");
            return true;
            
        }
    }
}
   
   