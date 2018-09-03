using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2_Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            bool[] lotto = new bool[50];

            for (int i = 0; i < 6; i++)
            {
                int ziehung = rnd.Next(1, 50);
                if (lotto[ziehung] == true)
                    i -= 1;
                else
                    lotto[ziehung] = true;
            }

            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if (lotto[j * i] == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("|" + (j * i).ToString().PadLeft(2, ' ') + " ");
                    }
                    else
                    {
                        Console.Write("| ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("| X ");
                    }
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("|\n-----------------------------\n");
            }
        }
    }
}
