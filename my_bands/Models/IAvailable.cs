using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_bands.Models
{
    internal interface IAvailable
    {
        void AddGrade(Avaliation grade);
        double Media { get; }
    }
}
