using my_bands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace my_bands.Menus
{
    internal class MenuInsertBand : Menu
    {

        public override void Execute(Dictionary<string, Band> registeredBand)
        {
            base.Execute(registeredBand);
            //Console.WriteLine("Write the name of your band to insert.");
            ShowTitleMenu("Write the name of your band to insert.");
            string bandName = Console.ReadLine();
            Band band = new Band(bandName);
            registeredBand.Add(bandName, band);
            Console.WriteLine($"The band {bandName} was inserted with success.");


            Thread.Sleep(2000);
            Console.Clear();
            //Console.WriteLine("\nPress any key to exit.");
            //showMenu();
        }
    }
}
