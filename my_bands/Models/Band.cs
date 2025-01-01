using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_bands.Models
{
    internal class Band
    {
        private List<Album> albums = new List<Album>();
        private List<Avaliation> grades = new List<Avaliation>();
        public double Media
        {
            get
            {
                if (grades.Count == 0) return 0;
                else return grades.Average(a => a.Grade);
            }
        }
        public string Name { get; }

        public Band(string name)
        {
            Name = name;
        }
        public void AddAlbum(Album album)
        {
            albums.Add(album);
        }

        public void AddGrade(Avaliation grade)
        {
            grades.Add(grade);
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
