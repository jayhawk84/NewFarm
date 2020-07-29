using System;
using System.Collections.Generic;
using System.Text;

namespace NewFarm
{
    class Rabbit : Animal
    {
        public Rabbit()
        {
            animalType = "rabbit";
            animalName = "Funny Bunny";
            animalColor = "Silver";
            animalSays = "You know why they call me Funny Bunny?  Oh, I wish you did, because I do not know either";
            Console.WriteLine($"Hello, I am a {this.animalType} and my name is {this.animalName}.\nPeople say that I am {this.animalColor} " +
                $"and to that I say {this.animalSays}");
        }

        public Rabbit(string type, string name, string color, string says)
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
