using my_bands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace my_bands.Menus
{
    internal class MenuInsertAlbum:Menu
    {

        public override void Execute(Dictionary<string, Band> registeredBand)
        {
            base.Execute(registeredBand);
            //Console.WriteLine("Write the name of your band to insert.");
            ShowTitleMenu("Write the name of your band to insert.");
            string bandName = Console.ReadLine();
            if (registeredBand.ContainsKey(bandName))
            {
                ShowTitleMenu("Write the title of the album to insert.");
                string albumName = Console.ReadLine();
                Band band = registeredBand[bandName];
                band.AddAlbum(new Album(albumName));
                Console.WriteLine($"The album {albumName} was inserted with success.");
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
