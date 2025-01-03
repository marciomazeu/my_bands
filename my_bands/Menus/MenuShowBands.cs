using my_bands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_bands.Menus
{
    internal class MenuShowBands:Menu
    {
        public override void Execute(Dictionary<string, Band> registeredBand)
        {
            base.Execute(registeredBand);
            //ShowTitleMenu("Exibindo todas as bandas registradas na nossa aplicação");
            ShowTitleMenu("Showing all enregistred bands in our application");
            foreach (string band in registeredBand.Keys)
            {
                Console.WriteLine($"Band: {band}");
            }

            Console.WriteLine("\nPress any key to return to menu.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
