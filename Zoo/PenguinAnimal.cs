
using System;

namespace Zoo
{
    public class PenguinAnimal : AbstractAnimals
    {
        public PenguinAnimal(string name)
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

        public override string Play(AbstractAnimals animal)
        {
            if (animal is PenguinAnimal)
            {
                return ($"animal played with {animal.Name}");
            }
            else
            {
                return ($"The animal cannot play with {animal.Name}");
            }
        }
        public override string Game(AbstractAnimals animal)
        {
            if (animal is PenguinAnimal)
            {
                return ($"{animal.Name} swimming");
            }

            else
            {
                return ($"{animal.Name} can't swim");
            }
        }
    }
}
