using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_bands.Models
{
    internal class Music
    {
        public string Name { get; }
        public Band Artist { get; }
        public int Duration { get; set; }
        public bool Available { get; set; }
        public string CompleteName => 
            $"The music {Name} belongs to the band {Artist}";

        public Gender Gender { get; set; }

        public Music(Band artist, string name)
        {
            Artist = artist;
            Name = name;
        }
        public void ShowTecInfo()
        {
            Console.WriteLine($"Nome: {Name}" );
            Console.WriteLine($"Artist: {Artist.Name}");
            Console.WriteLine($"Duration: {Duration}");
            if (Available)
            {
                Console.WriteLine($"Available into the plan.");
            }
            else
            {
                Console.WriteLine($"Not Available.");
            }
            Console.WriteLine($"------------------");
        }
    }
}
