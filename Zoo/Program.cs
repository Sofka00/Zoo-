using System;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penguin penguin = new Penguin("Simba");
            penguin.CountOfFood();
            penguin.Eat("Fish", -2);
            penguin.CountOfFood();
            Console.WriteLine(penguin.Eat("ggf", 3));
            penguin.Eat("ggf", 3);
            penguin.EatыPerDay();
            penguin.Say();
            penguin.Play();  
         
       
            
           


        }
    }
}
