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
    }
}
