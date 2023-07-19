using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Penguin : Animals
    {
        public Penguin(string name)
        {
            Name = name;
            Kind = "Penguin";
            Biom = "Tundra";
            Area = 10;
            Food = new string[1] { "Fish" };
            Predator = "Predator";
            Sound = "Oink-Oink";
            Sitost = 0;
            MaxSitost = 0.3;
            Age = 1;
        }
    }
}
