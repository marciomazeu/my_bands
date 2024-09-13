using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_bands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            showMenu();


            void showMenu()
            {
                Console.WriteLine("**********************");
                Console.WriteLine("MY BANDS");
                Console.WriteLine("**********************");

                Console.WriteLine("Press 1 to insert a new BAND.");
                Console.WriteLine("Press 2 to evaluate a BAND.");
                Console.WriteLine("Press 3 to see the average score of a BAND.");

                Console.ReadKey();
            }

        }
    }
}
