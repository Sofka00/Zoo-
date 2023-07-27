using System;


namespace Zoo
{
    public class Animals
    {
        public string Name { get; set; }
        protected string Kind { get; set; }
        protected string Biom { get; set; }
        protected int Area { get; set; }
        protected string[] Food { get; set; }
        protected string Predator { get; set; }
        protected string Sound { get; set; }
        protected double Sitost { get; set; }
        protected double MaxSitost { get; set; }
        protected int Age { get; set; }

        public Animals(string name, string kind, string biom, int area, string[] food, string predator, string sound, double sitost, double maxSitost,
    int age)
        {
            Name = name;
            Kind = kind;
            Biom = biom;
            Area = area;
            Food = food;
            Predator = predator;
            Sound = sound;
            Sitost = sitost;
            MaxSitost = maxSitost;
            Age = age;
        }

        public Animals()
        {
        }
        public void Say()
        {
            Console.WriteLine($"{Name} {Sound} ");
        }

        public string Eat(string food, double count)
        {
            if (count<0)
            {
                throw new ArgumentException("MENSHE NULL");
            }
            string result = "";

            foreach (string item in Food)
            {
                if (item == food && Sitost < MaxSitost)
                {
                    Sitost += count;
                    result = $"{Name} est";
                    break;
                }
                else
                {
                    result = $"{Name} ne est";
                    break;
                }
            }
                return result;

        }

        public void CountOfFood()
        {
            if (Sitost >= MaxSitost)
            {
                Console.WriteLine($"{Name} naelsya");
            }
            else
            {
                Console.WriteLine($"{Name} goloden");
            }
        }

        public void Play()
        {
            Console.WriteLine($"{Name} Play");
        }
        public void EatыPerDay()
        {
            Console.WriteLine($"{Name} eats per day {MaxSitost} kg.");
        }
    }

}
