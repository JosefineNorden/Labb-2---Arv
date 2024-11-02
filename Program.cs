using System.Drawing;

namespace Labb_2___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoo i Björketorp: ");
            
            // Create a new horse
            Horse horse = new Horse()
            {
                Name = "Giggan",
                Age = 16,
                Species = "häst",
                Gender = "sto",
                Diet = "växtätare",
                Speed = 50
            };

            //// Create a new animal with default values.
            //Animal animal = new Animal();
            //animal.OutPutInfo();
            //// Create a new horse with default values;
            //Horse horse2 = new Horse();
            //horse2.OutPutInfo();
            //// Create a  new shetland with default values;
            //Shetland shetland2 = new Shetland();
            //shetland2.OutPutInfo();

            // Show the information and actions by that horse created.
            horse.OutPutInfo();
            horse.Eat();
            horse.Sleep();
            horse.Galopp();
            horse.MakeSound();
            
            
            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();
            // Create a wildhorse
            WildHorse wildhorse = new WildHorse()
            {
                Name = "Spirit",
                Age = 3,
                Species = "häst",
                Gender = "hingst",
                Diet = "växtätare",
                Speed = 60

            };
            // Show the informations and actions by that wildhorse created.
            wildhorse.OutPutInfo();
            wildhorse.Eat();
            wildhorse.NotDomesticated();
            wildhorse.Sleep();
            wildhorse.Galopp();
            wildhorse.MakeSound();

            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();

            Shetland shetland = new Shetland()
            {
                Name = "Sigge",
                Age = 8,
                Species = "häst",
                Gender = "valack",
                Diet = "växtätare",

            };
            shetland.OutPutInfo();
            shetland.Eat();
            shetland.Sleep();
            shetland.Galopp();
            shetland.MakeSound();

            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();

           
            Dog dog = new Dog()
            {
                Name = "Göran",
                Age = 4,
                Species = "hund",
                Gender = "hane",
                Diet = "köttätare",
                Breed = "tax"
            };

            Dog dog2 = new Dog()
            {
                Name = "Nina",
                Age = 5,
                Species = "hund",
                Gender = "tik",
                Diet = "köttätare",
                Breed = "labrador"
            };

            dog.OutPutInfo();
            dog.Eat();
            dog.Sleep();
            dog.Fetch();
            dog.MakeSound();

            Console.WriteLine("");
            Console.WriteLine("Göran har en kompis också!");

            dog2.OutPutInfo();
            dog2.Fetch();
            dog2.MakeSound();

            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();


            Cat cat = new Cat()
            {
                Name = "Mysan",
                Age = 8,
                Species = "katt",
                Gender = "hona",
                Diet = "köttätare",
                Colour = "flerfärgad"
            };

            cat.OutPutInfo();
            cat.Eat();
            cat.Sleep();
            cat.Scratch();
            cat.MakeSound();

            Console.WriteLine("");
            Console.ReadKey();

        }
    }
}
