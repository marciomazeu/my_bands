using my_bands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_bands.Menus
{
    internal class MenuAverageRating:Menu
    {
        public override void Execute(Dictionary<string, Band> registeredBand)
        {
            base.Execute(registeredBand);
            ShowTitleMenu("Averate Rating");
            Console.Write("Wich band do you like to see the average note? ");
            string bandName = Console.ReadLine();
            Band band = registeredBand[bandName];
            double gradeAverage = band.Media;
            Console.WriteLine($"The average note of {bandName} is {gradeAverage}");
            Console.WriteLine("\nPress any key to return to menu.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
