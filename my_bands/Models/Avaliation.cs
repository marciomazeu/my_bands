using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_bands.Models
{
    internal class Avaliation
    {

        public int Grade { get; }

        public Avaliation(int grade) {
            if (grade > 10) grade = 10;
            if (grade < 0) grade = 0;
            Grade = grade; }

        public static Avaliation Parse(string text)
        {
            int grade = int.Parse(text);
            return new Avaliation(grade);
        }
    }
}
