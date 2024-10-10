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
            // List<string> band = new List<string>();
            Dictionary<string, List<int>> bands = new Dictionary<string, List<int>>();

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
                    case 3:
                        //Console.WriteLine("Voce sescolheu a opcao 2.");
                        evaluateBand();
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

                bands.Add(bandName, new List<int> ());
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
                //band.ForEach(x => Console.WriteLine(x));
                foreach (string band in bands.Keys)
                {
                    Console.WriteLine(band);
                }

                Thread.Sleep(2000);
                //Console.Clear();
                Console.WriteLine("\nPress any key to return to menu.");
                
                Console.ReadKey();
                //Console.Clear();
                showMenu();
            }

            void evaluateBand(){
                //digite qual banda deseja avaliar
                // se a banda existir no dicionario >> atribuir uma nota
                // senão, volta ao menu principal

                Console.Clear();
                Console.WriteLine("Evaluate the band");
                Console.Write("Type the name of the band to evaluate: ");
                string nomeDaBanda = Console.ReadLine();
                if (bands.ContainsKey(nomeDaBanda))
                {
                    Console.Write($"What note the band {nomeDaBanda} deserves? ");
                    int nota = int.Parse(Console.ReadLine());
                    bands[nomeDaBanda].Add(nota);
                    Console.WriteLine($"\nThe note {nota} was register with success for the band {nomeDaBanda}");
                    Thread.Sleep(2000);
                    Console.Clear();
                    showMenu();
                }
                else
                {
                    Console.WriteLine($"\nThe band {nomeDaBanda} was not found!");
                    Console.WriteLine("\nPress any key to return to menu.");
                    Console.ReadKey();
                    Console.Clear();
                    showMenu();
                }
            }
        }
    }
}
