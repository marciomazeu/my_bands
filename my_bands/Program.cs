using my_bands.Menus;
using my_bands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace my_bands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<string> band = new List<string>();
            //Dictionary<string, List<int>> bands = new Dictionary<string, List<int>>();
            Dictionary<string, Band> registeredBand = new Dictionary<string, Band>();

            Dictionary<int, Menu> options = new Dictionary<int, Menu>()
            {
                { 1, new MenuInsertBand() },
                { 2, new MenuShowBands() },
                { 3, new MenuBandEvaluation() },
                { 4, new MenuAverageRating() },
                { 5, new MenuShowDetails() },
                { -1, new MenuExit() }
            };

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
                Console.WriteLine("Press 5 to see the Band details.");
                Console.WriteLine("Press -1 to exit.");

                //int options = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nDigite a sua opção: ");
                string optionChosen = Console.ReadLine();
                int optionChoseTyped = int.Parse(optionChosen);

                if (options.ContainsKey(optionChoseTyped))
                {
                    Menu menu = options[optionChoseTyped];
                    menu.Execute(registeredBand);
                    if (optionChoseTyped > 0) showMenu();
                }
                else
                {
                    Console.WriteLine("Unknown option.");
                }
                Console.ReadKey();
            }
        }
    }
}
