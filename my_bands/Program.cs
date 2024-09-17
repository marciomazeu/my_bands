using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace my_bands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> band = new List<string>();

            showMenu();

           
            void showMenu()
            {
                Console.Clear();
                Console.WriteLine("**********************");
                Console.WriteLine("MY BANDS");
                Console.WriteLine("**********************");

                Console.WriteLine("Press 1 to insert a new BAND.");
                Console.WriteLine("Press 2 to show the BAND list.");
                Console.WriteLine("Press 3 to evaluate a BAND.");
                Console.WriteLine("Press 4 to see the average score of a BAND.");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        //Console.WriteLine("Voce escolheu a opcao 1.");
                        insertBand();
                        break;
                    case 2:
                        //Console.WriteLine("Voce sescolheu a opcao 2.");
                        showBand();
                        break;
                    default:
                        Console.WriteLine("Opcao desconhecida");
                        break;
                }

                Console.ReadKey();
            }

           void insertBand()
            {
                Console.Clear();
                Console.WriteLine("Write the name of your band to insert.");
                string bandName = Console.ReadLine();
                
                band.Add(bandName);
                Console.WriteLine($"Voce inseriu a banda {bandName} com sucesso.");


                Thread.Sleep(2000);
                Console.Clear();
                //Console.WriteLine("\nPress any key to exit.");
                showMenu();
            }

            void showBand()
            {
                Console.Clear();
                Console.WriteLine("Saved Bands:");
                band.ForEach(x => Console.WriteLine(x));

                Thread.Sleep(2000);
                //Console.Clear();
                Console.WriteLine("\nPress any key to return to menu.");
                
                Console.ReadKey();
                //Console.Clear();
                showMenu();
            }
        }
    }
}
