using my_bands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace my_bands.Menus
{
    internal class MenuBandEvaluation:Menu
    {
        public override void Execute(Dictionary<string, Band> registeredBand)
        {
            //digite qual banda deseja avaliar
            // se a banda existir no dicionario >> atribuir uma nota
            // senão, volta ao menu principal

            base.Execute(registeredBand);
            //Console.WriteLine("Evaluate the band");
            ShowTitleMenu("Evaluate the band");
            Console.Write("Type the name of the band to evaluate: ");
            string bandName = Console.ReadLine();
            if (registeredBand.ContainsKey(bandName))
            {
                Band band = registeredBand[bandName];
                Console.Write($"What note the band {bandName} deserves? ");
                Avaliation grade = Avaliation.Parse(Console.ReadLine());
                band.AddGrade(grade);
                Console.WriteLine($"\nThe note {grade.Grade} was register with success for the band {bandName}");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nThe band {bandName} was not found!");
                Console.WriteLine("\nPress any key to return to menu.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
