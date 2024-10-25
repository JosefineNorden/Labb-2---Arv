using System.Drawing;

namespace Labb_2___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoo i Björketorp: ");
            //string name, int age, string species, string gender, string diet
            Horse horse = new Horse()
            {
                Name = "Giggan",
                Age = 16,
                Species = "häst",
                Gender = "sto",
                Diet = "växtätare",
                Speed = 50
            };

            horse.OutPutInfo();
            horse.Eat();
            horse.Sleep();
            horse.Galopp();
            horse.MakeSound();

            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();

            WildHorse wildhorse = new WildHorse()
            {
                Name = "Spirit",
                Age = 3,
                Species = "häst",
                Gender = "hingst",
                Diet = "växtätare",
                Speed = 60

            };

            wildhorse.OutPutInfo();
            wildhorse.Eat();
            wildhorse.NotDomesticated();
            wildhorse.Sleep();
            wildhorse.Galopp();
            wildhorse.MakeSound();

            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();
            //string name, int age, string species, string gender, string diet, string breed
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

            // string name, int age, string species, string gender, string diet, string colour

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
