using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            do
            {
                uint zahl = 0;

                Console.Write("Zahl> ");
                zahl = Convert.ToUInt32(Console.ReadLine());

                uint fak = fakultaet(zahl);
                Console.WriteLine("Fakultät von {0} = {1}", zahl, fak);

                Console.Write("Nochmal? (j/n)");
                answer = Console.ReadLine();
            } while (answer == "j" || answer == "J");
        }

        static uint fakultaet(uint z)
        {
            uint fak = 1;

            if ( (z == 0) || (z == 1))
                return fak;
            else if (z > 1)
            {

                for (uint i = 2; i <= z; i++)
                {
                    fak *= i;
                }
            }
            return fak;
        }
    }
}
