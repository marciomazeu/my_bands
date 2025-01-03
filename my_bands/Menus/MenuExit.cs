using my_bands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_bands.Menus
{
    internal class MenuExit:Menu
    {
        public override void Execute(Dictionary<string, Band> registeredBand)
        {
            Console.WriteLine("Bye bye :)");
        }
    }
}
