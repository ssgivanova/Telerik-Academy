namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            //Create arrays of different kinds of animals and calculate the average age 
            //of each kind of animal using a static method (you may use LINQ).

            List<Animal> animals = new List<Animal>();

            List<Dog> dogs = new List<Dog>();
            List<Frog> frogs = new List<Frog>();
            List<Cat> cats = new List<Cat>();

            dogs.Add(new Dog("Sharo",3,SexType.Male));
            dogs.Add(new Dog("Lucky", 4, SexType.Male));
            dogs.Add(new Dog("Luisa", 5, SexType.Female));

            frogs.Add(new Frog("Kikerica", 1, SexType.Female));
            frogs.Add(new Frog("Jaburan", 2, SexType.Male));

            cats.Add(new Cat("Loulou", 3, SexType.Female));
            cats.Add(new Kitten("Fifi", 1));
            cats.Add(new Tomcat("Tom",3));

            animals.AddRange(dogs);
            animals.AddRange(frogs);
            animals.AddRange(cats);

            //produce sound
            foreach (var animal in animals)
            {
                Console.WriteLine("{0} - {1}",animal, animal.produceSound());
            }

            Console.WriteLine("\nAverage ages:");
            var animalsByType = animals.GroupBy(a => a.GetType()).Select(a => a).ToList();
            //average age of the animals
            foreach (var animal in animalsByType)
	        {                   
                Console.Write(animal.Key.Name +": ");
                double average = animal.Average(x => x.Age);
                //by static method in Animal
                //double average = Animal.GetAverageAge(animal);
                Console.WriteLine(average);
	        }
        }
    }
}
