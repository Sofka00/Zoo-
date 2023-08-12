using System;
namespace Zoo
{
    public class TigerAnimal : AbstractAnimals
    {
        public TigerAnimal(string name)
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
        public override string Play(AbstractAnimals animal)
        {
            if (animal is TigerAnimal)
            {
                return($" animal played with {animal.Name} ");
            }
            else
            {
               return ($"The animal cannot play with {animal.Name}");
            }
        }
        public override string Game(AbstractAnimals animal)
        {
            if (animal is TigerAnimal)
            {
               return ($"{animal.Name} hunts");
            }

            else
            {
                return ($"{animal.Name} can't hunt");
            }
        }
    }
}
