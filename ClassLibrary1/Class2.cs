using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    interface IAnimal
    {
        string MakeSound();
    }

    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        public string MakeSound()
        {
            return "Woof!";
        }
    }

    public class Cat : IAnimal
    {
        public string MakeSound()
        {
            return "Meow!";
        }
    }

    public class Animal : IAnimal
    {
        public string MakeSound()
        {
            return "Generic animal sound";
        }
        public string Eat()
        {
            return "Animal is eating.";
        }
    }

    public class Mammal : Animal
    {
        
        public string GiveBirth()
        {
            return "Mammal is giving birth.";
        }
    }

    public class Human : Mammal
    {
        public string Talk()
        {
            return "Human is talking.";
        }
    }

}
