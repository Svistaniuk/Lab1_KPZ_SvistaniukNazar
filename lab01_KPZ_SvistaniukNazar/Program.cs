using System;
using System.Collections.Generic;

public class Animal
{
    public string Species { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Enclosure
{
    public string Type { get; set; }
    public int Size { get; set; }
    public List<Animal> Animals { get; set; }

    public Enclosure(string type, int size)
    {
        Type = type;
        Size = size;
        Animals = new List<Animal>();
    }

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }
}

public class AnimalFood
{
    public string Type { get; set; }
    public double Quantity { get; set; }
}

public class ZooKeeper
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
}

public class Inventory
{
    public List<Enclosure> Enclosures { get; set; }
    public List<AnimalFood> FoodInventory { get; set; }
    public List<ZooKeeper> ZooKeepers { get; set; }

    public Inventory(List<Enclosure> enclosures, List<AnimalFood> foodInventory, List<ZooKeeper> zooKeepers)
    {
        Enclosures = enclosures;
        FoodInventory = foodInventory;
        ZooKeepers = zooKeepers;
    }

    public void DisplayInventory()
    {
        foreach (var enclosure in Enclosures)
        {
            Console.WriteLine($"Animals in {enclosure.Type} Enclosure:");
            foreach (var animal in enclosure.Animals)
            {
                Console.WriteLine($"Species: {animal.Species}, Name: {animal.Name}, Age: {animal.Age}");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Enclosures:");
        foreach (var enclosure in Enclosures)
        {
            Console.WriteLine($"Type: {enclosure.Type}, Size: {enclosure.Size}, Number of Animals: {enclosure.Animals.Count}");
        }

        Console.WriteLine("\nAnimal Food Inventory:");
        foreach (var food in FoodInventory)
        {
            Console.WriteLine($"Type: {food.Type}, Quantity: {food.Quantity}");
        }

        Console.WriteLine("\nZoo Keepers:");
        foreach (var keeper in ZooKeepers)
        {
            Console.WriteLine($"Name: {keeper.Name}, Age: {keeper.Age}, Department: {keeper.Department}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal lion = new Animal { Species = "Lion", Name = "Simba", Age = 5 };
        Animal elephant = new Animal { Species = "Elephant", Name = "Dumbo", Age = 10 };
        Animal giraffe = new Animal { Species = "Giraffe", Name = "Gerald", Age = 7 };
        Animal zebra = new Animal { Species = "Zebra", Name = "Marty", Age = 6 };

        Enclosure lionEnclosure = new Enclosure("Savanna", 100);
        lionEnclosure.AddAnimal(lion);

        Enclosure elephantEnclosure = new Enclosure("Jungle", 200);
        elephantEnclosure.AddAnimal(elephant);

        Enclosure giraffeEnclosure = new Enclosure("Savanna", 150);
        giraffeEnclosure.AddAnimal(giraffe);

        Enclosure zebraEnclosure = new Enclosure("Savanna", 120);
        zebraEnclosure.AddAnimal(zebra);

        AnimalFood meat = new AnimalFood { Type = "Meat", Quantity = 500 };
        AnimalFood hay = new AnimalFood { Type = "Hay", Quantity = 1000 };
        AnimalFood leaves = new AnimalFood { Type = "Leaves", Quantity = 800 };
        AnimalFood grass = new AnimalFood { Type = "Grass", Quantity = 600 };

        ZooKeeper keeper1 = new ZooKeeper { Name = "John", Age = 30, Department = "Lion Enclosure" };
        ZooKeeper keeper2 = new ZooKeeper { Name = "Alice", Age = 25, Department = "Elephant Enclosure" };
        ZooKeeper keeper3 = new ZooKeeper { Name = "Bob", Age = 35, Department = "Giraffe Enclosure" };
        ZooKeeper keeper4 = new ZooKeeper { Name = "Emily", Age = 28, Department = "Zebra Enclosure" };

        Inventory zooInventory = new Inventory(new List<Enclosure> { lionEnclosure, elephantEnclosure, giraffeEnclosure, zebraEnclosure },
                                                new List<AnimalFood> { meat, hay, leaves, grass },
                                                new List<ZooKeeper> { keeper1, keeper2, keeper3, keeper4 });
        zooInventory.DisplayInventory();

        Console.WriteLine("Testing completed successfully!");
    }
}
