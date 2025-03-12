using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_bands.Models
{
    internal class Album :IAvailable
    {
        public List<Music> musics = new List<Music>(); 
        public List<Avaliation> albumGrades = new List<Avaliation>();
        public string Name { get; }

        public int TotalDuration => musics.Sum(m => m.Duration);

        public Album(string name)
        {
            Name = name;
        }
        public void AddMusic(Music music)
        {
            musics.Add(music);
        }

        public double Media
        {
            get
            {
                if (albumGrades.Count == 0) return 0;
                else return albumGrades.Average(grade => grade.Grade);
            }
        }

        public void AddGrade(Avaliation albumGrade)
        {
            albumGrades.Add(albumGrade);
        }
        public void ShowMusics()
        {
            Console.WriteLine($"List of musics from {Name}:\n");
            foreach (var music in musics)
            {
                Console.WriteLine($"Music: {music.Name}");
            }

            Console.WriteLine($"\nTo listen this album you need {TotalDuration} seconds.\n");
        }
    }
}
