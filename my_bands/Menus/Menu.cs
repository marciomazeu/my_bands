using my_bands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_bands.Menus
{
    internal class Menu
    {
        public void ShowTitleMenu(string title)
        {
            int letterQuantity = title.Length;
            string asterisks = string.Empty.PadLeft(letterQuantity, '*');
            Console.WriteLine(asterisks);
            Console.WriteLine(title);
            Console.WriteLine(asterisks + '\n');
        }

        public virtual void Execute(Dictionary<string, Band> registeredBand)
        {
            Console.Clear();
        }
    }
}
