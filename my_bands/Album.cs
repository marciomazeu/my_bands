using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_bands
{
    internal class Album
    {
        public List<Music> musics = new List<Music>(); 
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
