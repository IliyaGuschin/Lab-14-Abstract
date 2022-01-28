using System;

namespace Lab_14_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое животное: ");
            Cat CurrentAnimal1 = new Cat();
            CurrentAnimal1.Name = "Кот Матроскин";
            CurrentAnimal1.ShowInfo();
            Console.WriteLine(CurrentAnimal1.Say());

            Console.WriteLine("\n");

            Console.WriteLine("Второе животное: ");
            Dog CurrentAnimal2 = new Dog();
            CurrentAnimal2.Name = "Пес Шарик";
            CurrentAnimal2.ShowInfo();
            Console.WriteLine(CurrentAnimal2.Say());

        }
    }

    public abstract class Animal
    {

        public string Name { get; set; }

        public Animal()
        {
            Name = "Какое-то животное";
        }

        public abstract string Say();

        public void ShowInfo()
        {
            Console.WriteLine(this.Name + " произносит:");
        }

    }

    class Cat : Animal
    {


        public override string Say()
        {
            return "Мяу";
        }

    }

    class Dog : Animal
    {
        public override string Say()
        {
            return "Гав";
        }
    }

}
