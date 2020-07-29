using System;
using System.Collections.Generic;
using System.Text;

namespace NewFarm
{
    public class Fox : Animal
    {
        public Fox()
        {
            animalType = "fox";
            animalName = "unknown varmint";
            animalColor = "burnt umber";
            animalSays = "yippee ki yay mothertrucker";
            Console.WriteLine($"Hello, I am a {this.animalType} and my name is {this.animalName}.\nPeople say that I am {this.animalColor} " +
                $"and to that I say {this.animalSays}");
        }
        public Fox(string type, string name, string color, string says)
        {
            animalType = type;
            animalName = name;
            animalColor = color;
            animalSays = says;
            Console.WriteLine($"Hello, I am a {this.animalType} and my name is {this.animalName}.\nPeople say that I am {this.animalColor} " +
                $"and to that I say {this.animalSays}");
        }

        //public string NewFox()
        //{
        //    Console.WriteLine($"Hello, I am a {animalType} and my name is {animalName}.\nPeople say that I am {animalColor} " +
        //        $"and to that I say {animalSays}");
        //}
    }
}
