using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var snake1 = new Reptile();
            snake1.Age = 7;
            snake1.Class = "poisonous";
            snake1.Name = "Black Mamba";
            snake1.Size = 14;
            snake1.Type = "cold blooded";
            snake1.Legs = 0;
            snake1.Habitat = "Sub-Saharan African woodlands";
            snake1.Diet = "carnivores";

            var bird1 = new Bird();
            bird1.Type = "warm blooded";
            bird1.Age = 7;
            bird1.Color = "blue";
            bird1.Diet = "omnivorous";
            bird1.Feather = "contour flight feathers";
            bird1.Sound = "jeer";
            bird1.Name = "Blue Jay";
            bird1.Beak = "medium curved beak";


            Console.WriteLine($"Here are some fun facts about {bird1.Name}s! {bird1.Name}s are {bird1.Type} animals and can grow up to {bird1.Age} years old!" +
                              $"\nThese birds usually have beautiful {bird1.Color} {bird1.Feather}." +
                              $"\nWith {bird1.Beak}s, {bird1.Name}'s are primarily subject to an {bird1.Diet} diet. An example of how they sound is 'Jeer'!");

            Console.WriteLine($"\n\nI have a pet snake named Lary. Lary is a {snake1.Size} foot, {snake1.Type} {snake1.Class} {snake1.Name}." +
                              $"\nHe's from the {snake1.Habitat}, and i've had him for about {snake1.Age} years. Because {snake1.Name}'s are {snake1.Diet}, I cant just feed him anything. ");


            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
