using my_bands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace my_bands.Menus
{
    internal class MenuAlbumEvaluation : Menu
    {
        public override void Execute(Dictionary<string, Band> registeredBand)
        {
            base.Execute(registeredBand);

            ShowTitleMenu("Album Evaluation");
            Console.Write("Type the name of the band to evaluate: ");
            string bandName = Console.ReadLine();
            if (registeredBand.ContainsKey(bandName))
            {
                Band band = registeredBand[bandName];
                Console.Write("Agora digite o título do álbum: ");
                string albumTitle = Console.ReadLine();
                if (band.albums.Any(a => a.Name.Equals(albumTitle)))
                {
                    Album album = band.albums.First(a => a.Name.Equals(albumTitle));
                    Console.Write($"What grade the álbum {albumTitle} deserves: ");
                    Avaliation grade = Avaliation.Parse(Console.ReadLine());
                    
                    album.AddGrade(grade);
                    Console.WriteLine($"\nThe note {grade.Grade} was register with success for the album {albumTitle}");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"\nThe album {albumTitle} was not found!");
                    Console.WriteLine("\nPress any key to return to menu.");
                    Console.ReadKey();
                    Console.Clear();
                }
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
