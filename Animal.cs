using System;

namespace Labb_2___Arv

    
{
    // Base class representing an animal.
    public class Animal
    {
        public string Name { get; set; } = "Okänd"; // Default name
        public int Age { get; set; } = 0; // Default age
        public string Species { get; set; } = "Okänd"; // Default species
        public string Gender { get; set; } = "Okänd"; // Default gender
        public string Diet { get; set; } = "Okänd"; // Default diet
            

        // Default constructor
        public Animal()
        {
            Name = "Okänt";
            Age = 0;
            Species = "Okänt";
            Gender = "Okänt";
            Diet = "Okänt";
        }
        // Constructor with parameters to set properties
        public Animal(string name, int age, string species, string gender, string diet)
        {
            Name = name;
            Age = age;
            Species = species;
            Gender = gender;
            Diet = diet;
        }

        // Virtual method to output information about the animal
        public virtual void OutPutInfo()
        {
            Console.WriteLine($"Namm: {Name}, Ålder: {Age}, Art: {Species}, Kön: {Gender}, Kost: {Diet}.");
        }
        // Virtual method to represent the animal making a sound
        public virtual void MakeSound()
        {
            Console.WriteLine("Djuret lät!");
        }
        // Virtual method to represent the animal eating
        public virtual void Eat()
        {
            Console.WriteLine("Djuret äter!");
        }

        // Virtual method to represent the animal sleeping
        public virtual void Sleep()
        {
            Console.WriteLine("Djuret sover... zZzzzz...");
        }
    }
    // Class horse, which inherits from animal class
    public class Horse : Animal
    {
        public int Speed { get; set; } // Speed of the horse
        
        //Default constructor
        public Horse() : base()
        {
            Speed = 0;
            Species = "häst";
            Diet = "växtätare";
        }
        // Constructor with parameters
        public Horse(string name, int age, string species, string gender, string diet, int speed)
            : base(name, age, species, gender, diet)
        {
            Speed = speed;
            Species = "häst"; // Set species to "horse"
            Diet = "växtätare"; // Set Diet to "växtätare"
        }

        // Override to make a horse sound
        public override void MakeSound()
        {
            Console.WriteLine("Gnägg!!!");
        }
        // Override to describe how a horse eats
        public override void Eat()
        {
            Console.WriteLine($"{Species}ar är {Diet} så dom äter gräs och hö.");
        }
        // Override to describe how a horse sleeps.
        public override void Sleep()
        {
            Console.WriteLine($"En {Species} kan sova både liggandes och ståendes.");
        }
        // Override to output horse info
        public override void OutPutInfo()
        {
            Console.WriteLine($"Namm: {Name}, Ålder: {Age}, Art: {Species}, Kön: {Gender}, Kost: {Diet}.");
        }
        // Method specific to Horse to represent galloping
        public void Galopp()
        {
            Console.WriteLine($"{Name} galopperade iväg i {Speed} km/h!");
        }
    }
    // Class Wildhorse, witch inherits from class Horse
    public class WildHorse : Horse
    {
        public string Habitat { get; set; } // Habitat of the wild horse
        public string Breed { get; set; } // Breed of the wild horse
        // Default constructor
        public WildHorse() : base()
        {
            Habitat = "Vilda Western"; // Default habitat
            Breed = "Mustang"; // Default breed

        }
        // Constructor with parameters
        public WildHorse(string name, int age, string gender, string diet, int speed)
            : base(name, age, "Vildhäst", gender, diet, speed)
        {
            Habitat = "Vilda Western";
            Breed = "Mustang";
        }
        // Override to make a wild horse sound
        public override void MakeSound()
        {
            Console.WriteLine("Gnägg!!!");
        }
        // Override to describe how a wild horse eats
        public override void Eat()
        {
            Console.WriteLine($"En {Breed} är {Diet} så den äter gräs i det vilda.");
        }
        // Override to describe how a wild horse sleeps
        public override void Sleep()
        {
            Console.WriteLine($"En {Breed} föredrar att sova ståendes så den kan fly från faror.");
        }
        // Override to output wild horse info 
        public override void OutPutInfo()
        {
            Console.WriteLine($"Namm: {Name}, Ålder: {Age}, Art: Vildhäst, Kön: {Gender}, Kost: {Diet}.");
        }
        // Method specific to wildhorse to describe its wild nature
        public void NotDomesticated()
        {
            Console.WriteLine($"En {Species} som lever i {Habitat} är vild och lever i det fria, rasen kallas för {Breed}.");
        }
    }
    // Class Shetland which inherits from horse
    public class Shetland : Horse
    {
        public string Breed { get; set; } // Breed of the shetland horse

        //Default constructor
        public Shetland() : base()
        {

            Breed = "Shetland"; // Set breed
            Speed = 20; // Default speed

        }
        // Constructor with parameters
        public Shetland(string name, int age, string gender, string diet, int speed) : base(name, age, "Shetland", gender, diet, speed)
        {
            Breed = "Shetland"; // Set breed
            Speed = 20; // Set speed

        }
        // Override methods not adding any new funcionality 
        public override void MakeSound()
        {
            base.MakeSound(); // Call the base method
        }

        public override void Eat()
        {
            base.Eat();
        }
        public override void Sleep()
        {
            base.Sleep();
        }
        public override void OutPutInfo()
        {
            base.OutPutInfo();
        }
        
    }

    // Class Dog which inherits from animal
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
            // Differnet behavior based on breed
            if (breed != "tax") 
            {
                Console.WriteLine("Woooff!!");

            }
            else
            {
                Console.WriteLine("Wooff...");
            }
        }
        // Override to describe how a dog eats
        public override void Eat()
        {
            Console.WriteLine($"En {Species} är {Diet} så den äter hundmat som innehåller kött.");
        }
        // Override to describe how a dog sleeps
        public override void Sleep()
        {
            Console.WriteLine($"{Name} sover på soffan!");
        }
        // Override to output dog info
        public override void OutPutInfo()
        {
            Console.WriteLine($"Namm: {Name}, Ålder: {Age}, Art: {Species}, Kön: {Gender}, Kost: {Diet}.");
        }
        // Method specific to dog to represent fetching
        public void Fetch()
        {
            string breed = Breed;
            // Differnet behavior based on breed
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

    // Class Cat which inherits from animal class
    public class Cat : Animal
    {
        public string Colour { get; set; } // Colour of the cat

        // DEfault constructor
        public Cat() : base()
        {
            Colour = "Okänt"; // Default colour
        }

        // Constructor with parameters
        public Cat(string name, int age, string species, string gender, string diet, string colour)
            : base(name, age, species, gender, diet)
        {
            Colour = colour; // Set colour
        }
        // Override to make a cat sound
        public override void MakeSound()
        {
            Console.WriteLine("Mjaoooo!!!");
        }
        // Override to describe how a cat eats
        public override void Eat()
        {
            Console.WriteLine($"En {Species} är köttätare så den äter kattmat som innehåller kött.");
        }
        // Override to describe how a lazy cat sleeps
        public override void Sleep()
        {
            Console.WriteLine($"{Name} är en lat {Species} och sover nästan hela dagarna....");
        }
        // Override to output cat info
        public override void OutPutInfo()
        {
            Console.WriteLine($"Namm: {Name}, Ålder: {Age}, Art: {Species}, Kön: {Gender}, Kost: {Diet}.");
        }
        // Specific methot to Cat to represent scratching
        public void Scratch()
        {
            Console.WriteLine($"{Name} är {Colour} och tycker om att klösa på saker.");
        }
    }
}
