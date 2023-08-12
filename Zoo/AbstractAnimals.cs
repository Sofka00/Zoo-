using System;


namespace Zoo
{
    public abstract class AbstractAnimals
    {

        public string Name { get; set; }
       public string Kind {  get; protected set; }
        public string Biom { get; protected set; }
        public int Area { get; protected set; }
        public string[] Food { get; protected set; }
        public string Predator { get; protected set; }
        public string Sound { get; protected set; }
        public double Sitost { get; protected set; }
        public double MaxSitost { get; protected set; }
        public  int Age { get; protected set; }
        public abstract string Play(AbstractAnimals animal);
        public abstract string Game(AbstractAnimals animal);
       
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

        public void EatPerDay()
        {
            Console.WriteLine($"{Name} eats per day {MaxSitost} kg.");
        }
    }

}
