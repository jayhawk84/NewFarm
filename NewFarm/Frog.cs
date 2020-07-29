using System;
using System.Collections.Generic;
using System.Text;

namespace NewFarm
{
    class Frog : Animal
    {
        public Frog()
        {
            animalType = "Frog";
            animalName = "Frogger";
            animalColor = "green";
            animalSays = "ribbit";
            Console.WriteLine($"Hello, I am a {this.animalType} and my name is {this.animalName}.\nPeople say that I am {this.animalColor} " +
                $"and to that I say {this.animalSays}");
        }

        public Frog(string type, string name, string color, string says)
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
