
using System;

namespace Zoo
{
    public class ElephantAnimal : AbstractAnimals
    {
        public ElephantAnimal(string name)
        {
            Name = name;
            Kind = "Elephant";
            Biom = "desert";
            Area = 10;
            Food = new string[1] { "Hay" };
            Predator = "Mammal";
            Sound = "Auf-Auf";
            Sitost = 0;
            MaxSitost = 5;
            Age = 5;
        }
        public override string Play(AbstractAnimals animal)
        {
            if (animal is ElephantAnimal)
            {
                return ($" animal played with {animal.Name} ");
            }
            else
            {
                return ($"The animal cannot play with {animal.Name}");
            }
        }
        public override string Game(AbstractAnimals animal)
        {
            if (animal is ElephantAnimal)
            {
                return ($"{animal.Name} running around");
            }

            else
            {
                return($"{animal.Name} can't run");
            }

           
        }
    }

}
