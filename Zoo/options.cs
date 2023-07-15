using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animals
    {
        public string Kind { get; set; }
        public string Biom { get; set; }
        public int Area { get; set; }

        public string[] Food { get; set; }
        public string Predador { get; set; }
        public string Sound { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }
        private int _age;


        public void Say()
        {
            Console.WriteLine($"{Name} {Sound} ");
        }

        public void Eat()
        {
            string result = "";
            foreach (var item in Food)
            {
                result += " ";
                result+= item;
            }
            Console.WriteLine($"{Name} Eat{result} ");
        }

        public void Play()
        {
            Console.WriteLine($"{Name} Play");
        }
        public void EatыPerDay()
        {
            Console.WriteLine($"{Name} eats per day {Quantity} kg."); 
        }


    }
}
