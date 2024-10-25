using System;

namespace Labb_2___Arv
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string Diet { get; set; }

        public Animal()
        {
            Name = "Okänt";
            Age = 0;
            Species = "Okänt";
            Gender = "Okänt";
            Diet = "Okänt";
        }

        public Animal(string name, int age, string species, string gender, string diet)
        {
            Name = name;
            Age = age;
            Species = species;
            Gender = gender;
            Diet = diet;
        }


        public virtual void OutPutInfo()
        {
            Console.WriteLine($"Namm: {Name}, Ålder: {Age}, Art: {Species}, Kön: {Gender}, Kost: {Diet}.");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Djuret lät!");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Djuret äter!");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Djuret sover... zZzzzz...");
        }
    }

    public class Horse : Animal
    {
        public int Speed { get; set; }

        public Horse() : base()
        {
            Speed = 0;
        }

        public Horse(string name, int age, string species, string gender, string diet, int speed)
            : base(name, age, species, gender, diet)
        {
            Speed = speed;
        }


        public override void MakeSound()
        {
            Console.WriteLine("Gnägg!!!");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Species}ar är {Diet} så dom äter gräs och hö.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"En {Species} kan sova både liggandes och ståendes.");
        }

        public override void OutPutInfo()
        {
            Console.WriteLine($"Namm: {Name}, Ålder: {Age}, Art: {Species}, Kön: {Gender}, Kost: {Diet}.");
        }

        public void Galopp()
        {
            Console.WriteLine($"{Name} galopperade iväg i {Speed} km/h!");
        }
    }

    public class WildHorse : Horse
    {
        public string Habitat { get; set; }
        public string Breed { get; set; }

        public WildHorse() : base()
        {
            Habitat = "Vilda Western";
            Breed = "Mustang";
        }
        public WildHorse(string name, int age, string gender, string diet, int speed)
            : base(name, age, "Vildhäst", gender, diet, speed)
        {
            Habitat = "Vilda Western";
            Breed = "Mustang";

        }
        public override void MakeSound()
        {
            Console.WriteLine("Gnägg!!!");
        }

        public override void Eat()
        {
            Console.WriteLine($"En {Breed} är {Diet} så den äter gräs i det vilda.");
        }
        public override void Sleep()
        {
            Console.WriteLine($"En {Breed} föredrar att sova ståendes så den kan fly från faror.");
        }
        public override void OutPutInfo()
        {
            Console.WriteLine($"Namm: {Name}, Ålder: {Age}, Art: Vildhäst, Kön: {Gender}, Kost: {Diet}.");
        }
        public void NotDomesticated()
        {
            Console.WriteLine($"En {Species} som lever i {Habitat} är vild och lever i det fria, rasen kallas för {Breed}.");
        }
    }
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog() : base()
        {
            Breed = "Okänt";
        }
        public Dog(string name, int age, string species, string gender, string diet, string breed)
            : base(name, age, species, gender, diet)
        {
            Breed = breed;
        }

        public override void MakeSound()
        {
            string breed = Breed;

            if (breed != "tax")
            {
                Console.WriteLine("Woooff!!");

            }
            else
            {
                Console.WriteLine("Wooff...");
            }
        }
        public override void Eat()
        {
            Console.WriteLine($"En {Species} är {Diet} så den äter hundmat som innehåller kött.");
        }
        public override void Sleep()
        {
            Console.WriteLine($"{Name} sover på soffan!");
        }
        public override void OutPutInfo()
        {
            Console.WriteLine($"Namm: {Name}, Ålder: {Age}, Art: {Species}, Kön: {Gender}, Kost: {Diet}.");
        }
        public void Fetch()
        {
            string breed = Breed;

            if (breed != "tax")
            {
                Console.WriteLine($"{Name} är av rasen {Breed} och älskar att jaga sin frisbee!");

            }
            else
            {
                Console.WriteLine($"{Name} är en gammal {Breed} och sover helst hela dagarna...zzZZzzz");
            }
        }
    }

    public class Cat : Animal
    {
        public string Colour { get; set; }

        public Cat() : base()
        {
            Colour = "Okänt";
        }

        public Cat(string name, int age, string species, string gender, string diet, string colour)
            : base(name, age, species, gender, diet)
        {
            Colour = colour;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Mjaoooo!!!");
        }

        public override void Eat()
        {
            Console.WriteLine($"En {Species} är köttätare så den äter kattmat som innehåller kött.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{Name} är en lat {Species} och sover nästan hela dagarna....");
        }

        public override void OutPutInfo()
        {
            Console.WriteLine($"Namm: {Name}, Ålder: {Age}, Art: {Species}, Kön: {Gender}, Kost: {Diet}.");
        }

        public void Scratch()
        {
            Console.WriteLine($"{Name} är {Colour} och tycker om att klösa på saker.");
        }
    }
}
