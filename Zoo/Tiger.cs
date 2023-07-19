using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Tiger : Animals
    {
        public Tiger(string name)
        {
            Name = name;
            Kind = "Tiger";
            Biom = "tropics";
            Area = 10;
            Food = new string[2] { "Fish", "Meet" };
            Predator = "Predator";
            Sound = "Grr-Grr";
            Sitost = 0;
            MaxSitost = 5;
            Age = 20;
        }
    }
}
