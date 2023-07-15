using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals elephant = new Animals();
            elephant.Name = "Petya";
            elephant.Kind = "Slon";
            elephant.Biom = "Tropici";
            elephant.Food = new string[1] {"Fish"};
            elephant.Age = -5;
            elephant.Sound = "oink-oink";
            elephant.Quantity = 5;
            elephant.Say();
            elephant.Eat();
            elephant.Play();
            Animals penguin = new Animals();
            penguin.Name = "Simba";
            penguin.Kind = "Pinguin";
            penguin.Biom = "Tundra";
            penguin.Food = new string[2] { "Fish", "Meet" };
            penguin.Age = 1;
            penguin.Sound = "auf-auf";
            penguin.Quantity = 0.3;
            penguin.Say();
            penguin.Eat();
            penguin.Play();
            Animals tiger = new Animals();
            tiger.Name = "Matilda";
            tiger.Kind = "Tiger";
            tiger.Biom = "Desert";
            tiger.Food = new string[2] { "Fish", "Meet" };
            tiger.Age = 20;
            tiger.Sound = "Grr-Grr";
            tiger.Quantity = 5;
            tiger.Say();
            tiger.Eat();
            tiger.Play();
        }
    }
}
