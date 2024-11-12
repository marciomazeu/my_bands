using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_bands
{
    internal class Band
    {
        private List<Album> albums = new List<Album>();

        public string Name { get; }

        public Band(string name)
        {
            Name = name;
        }
        public void AddAlbum(Album album)
        {
            albums.Add(album);
        }

        public void ShowDiscography()
        {
            Console.WriteLine($"{Name} Discography band");
            foreach (Album album in albums)
            {
                Console.WriteLine($"Álbum: {album.Name} ({album.TotalDuration} seconds)");
            }
        }
    }
}
