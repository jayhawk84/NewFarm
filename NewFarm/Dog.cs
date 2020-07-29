using System;
using System.Collections.Generic;
using System.Text;

namespace NewFarm
{
    class Dog : Animal
    {
        public Dog()
        {
            animalType = "dog";
            animalName = "Marmelot";
            animalColor = "Caramel";
            animalSays = "Will you be my best friend?";
            Console.WriteLine($"Hello, I am a {this.animalType} and my name is {this.animalName}.\nPeople say that I am {this.animalColor} " +
                $"and to that I say {this.animalSays}");
        }

        public Dog(string name)
        {
            animalName = name;
            animalType = "dog";
            animalColor = "white";
            animalSays = "I rarely have something original to say";
            Console.WriteLine($"Hello, I am a {this.animalType} and my name is {this.animalName}.\nPeople say that I am {this.animalColor} " +
                $"and to that I say {this.animalSays}");
        }
        public Dog(string type, string name, string color, string says)
        {
            animalType = type;
            animalName = name;
            animalColor = color;
            animalSays = says;
            Console.WriteLine($"Hello, I am a {this.animalType} and my name is {this.animalName}.\nPeople say that I am {this.animalColor} " +
                $"and to that I say {this.animalSays}");
        }
    }
}
