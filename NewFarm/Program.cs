//Jason Horvath
//ISTA 220
//25 July 2020

//Create a Farm HW


using System;

namespace NewFarm
{
    class Program
    {

        static void createFarm()
        {
            Fox Bilbo = new Fox("fox", "Bilbo", "red", "do you have any tobacco?");

            Fox Cholo = new Fox();

            Frog Cyrano = new Frog();

            Frog Cyrus = new Frog("frog", "Cyrus", "green of course", "have you seen my buddy Chrono around here?");

            Rabbit Buster = new Rabbit();

            Rabbit Bucky = new Rabbit("hare", "Bucky O'Hare", "green", "do you feel lucky, punk?");

            Dog Chloe = new Dog("Chloe");

            Dog Eliot = new Dog("puppy", "wilma", "red", "woof");
        }

        static void Main(string[] args)
        {

            try
            {
                createFarm();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
