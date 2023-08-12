using System;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PenguinAnimal penguin = new PenguinAnimal("Simba");
            penguin.CountOfFood();
            penguin.Eat("Fish", 0.3);
            penguin.CountOfFood();
            Console.WriteLine(penguin.Eat("ggf", 3));
            penguin.Eat("ggf", 3);
            penguin.EatPerDay();
            penguin.Say();
            Console.WriteLine(penguin.Play(penguin));

        }
    }
}
