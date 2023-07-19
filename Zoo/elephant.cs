using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Elephant : Animals
    {
        public Elephant(string name)
        {
            Name = name;
            Kind = "Elephant";
            Biom = "desert";
            Area = 10;
            Food = new string[1] {"Hay"};
            Predator = "Mammal";
            Sound = "Auf-Auf";
            Sitost = 0;
            MaxSitost = 5;
            Age = 5;
        }
    }
}
