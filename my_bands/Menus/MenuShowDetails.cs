using my_bands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_bands.Menus
{
    internal class MenuShowDetails : Menu
    {
        public override void Execute(Dictionary<string, Band> registeredBand)
        {
            base.Execute(registeredBand);
            //Console.WriteLine("View band details");
            ShowTitleMenu("View band details");
            Console.Write("Enter the name of the band you want to know better: ");
            string bandName = Console.ReadLine();
            if (registeredBand.ContainsKey(bandName))
            {
                Band band = registeredBand[bandName];
                Console.WriteLine($"\nThe band {bandName} has rating {band.Media} as average.");
                /**
                * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
                */
                foreach (Album album in band.albums)
                {
                    Console.WriteLine($"Album: {album.Name} -> {album.Media}");
                }
                Console.WriteLine("Press any key to return to menu.");
                Console.ReadKey();
                Console.Clear(); 
            }
            else
            {
                Console.WriteLine($"\nA banda {bandName} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
