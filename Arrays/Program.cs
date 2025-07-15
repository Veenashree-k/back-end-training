namespace AnimalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];

            animals[0] = new Animal("Buddy", "Dog", 5);
            animals[1] = new Animal("Whiskers", "Cat", 3);
            animals[2] = new Animal("Charlie", "Parrot", 2);

            Console.WriteLine("-- Animal List --");
            foreach (Animal animal in animals)
            {
                animal.Speak();
            }
        }
    }

    class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }

        public Animal(string name, string species, int age)
        {
            Name = name;
            Species = species;
            Age = age;
        }

        public void Speak()
        {
            Console.WriteLine($"Hi, I'm {Name} the {Species}. I'm {Age} years old.");
        }
    }
}
