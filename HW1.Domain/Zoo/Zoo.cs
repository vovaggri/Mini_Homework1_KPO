using HW1.Domain.Animals;
using HW1.Domain.Things;

namespace HW1.Domain.Zoo;

public class Zoo
{
    private readonly IVetClinic _vetClinic;
    private readonly IInventoryNumberGenerator _inventoryGenerator;
    
    public List<Animal> Animals { get; } = new List<Animal>();
    public List<Thing> Things { get; } = new List<Thing>();

    public Zoo(IVetClinic vetClinic, IInventoryNumberGenerator inventoryGenerator)
    {
        _vetClinic = vetClinic;
        _inventoryGenerator = inventoryGenerator;
        
        // For demo, added one table and one computer.
        string tableName = "Base table";
        string computerName = "Base computer";
        var table = new Table(tableName);
        var computer = new Computer(computerName);
        AddThing(table);
        AddThing(computer);
    }

    /// <summary>
    /// Adding animal with checking health.
    /// </summary>
    /// <param name="animal"></param>
    public void AddAnimal(Animal animal)
    {
        animal.Number = _inventoryGenerator.GetNextInventoryNumber();

        if (_vetClinic.CheckHealth(animal))
        {
            Animals.Add(animal);
            Console.WriteLine($"Animal {animal.Name} added successfully!");
        }
        else
        {
            Console.WriteLine($"Animal {animal.Name} failed checking health and wasn't added!");
        }
    }

    /// <summary>
    /// Adding things.
    /// </summary>
    /// <param name="thing"></param>
    public void AddThing(Thing thing)
    {
        thing.Number = _inventoryGenerator.GetNextInventoryNumber();
        
        Things.Add(thing);
        Console.WriteLine($"Thing {thing.Name} added successfully!");
    }

    /// <summary>
    /// Return the number of food consumption.
    /// </summary>
    /// <returns></returns>
    public int GetTotalFoodConsumption()
    {
        int total = 0;
        foreach (var animal in Animals)
        {
            total += animal.Food;
        }

        return total;
    }

    /// <summary>
    /// Get interactive animals.
    /// </summary>
    /// <returns></returns>
    public List<Herbo> GetInteractiveAnimals()
    {
        List<Herbo> interactiveAnimals = new List<Herbo>();

        foreach (var animal in Animals)
        {
            if (animal is Herbo herbo && herbo.Kindness > 5)
            {
                interactiveAnimals.Add(herbo);
            }
        }
        
        return interactiveAnimals;
    }

    /// <summary>
    /// Showing inventory intems.
    /// </summary>
    public void PrintInventoryItems()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("\nInventory of animals:");
        foreach (var animal in Animals)
        {
            Console.WriteLine($"\nName: {animal.Name}, Number: {animal.Number}");
        }
        
        Console.WriteLine("--------------------------");
        Console.WriteLine("\nInventory of things:");
        foreach (var thing in Things)
        {
            Console.WriteLine($"\nName: {thing.Name}, Number: {thing.Number}");
        }
    }
}