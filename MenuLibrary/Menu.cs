using HW1.Domain;
using HW1.Domain.Animals;
using HW1.Domain.Things;

namespace MenuLibrary;
using HW1.Domain.Zoo;

public static class Menu
{
    public static void MenuMain(Zoo zoo)
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("-------Main Menu-------");
            Console.WriteLine("1. Add a new animal");
            Console.WriteLine("2. Add a new thing");
            Console.WriteLine("3. Show all food consumption");
            Console.WriteLine("4. Show animals for contact zoo");
            Console.WriteLine("5. Show inventory things");
            Console.WriteLine("6. Exit");
            
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddAnimalMenu(zoo);
                    break;
                case "2":
                    AddThingMenu(zoo);
                    break;
                case "3":
                    int totalFood = zoo.GetTotalFoodConsumption();
                    Console.WriteLine($"Total food consumption: {totalFood}");
                    Console.Write("Touch enter to return to Main menu");
                    Console.ReadLine();
                    break;
                case "4":
                    var interactiveAnimals = zoo.GetInteractiveAnimals();
                    Console.WriteLine("\nAnimals for contact zoo:");
                    foreach (var animal in interactiveAnimals)
                    {
                        Console.WriteLine($"Name: {animal.Name}, Type: {animal.Type}, Kindness: {animal.Kindness}");
                    }
                    Console.Write("Touch enter to return to Main menu");
                    Console.ReadLine();
                    break;
                case "5":
                    zoo.PrintInventoryItems();
                    Console.Write("Touch enter to return to Main menu");
                    Console.ReadLine();
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option! Try again!");
                    break;
            }
        }
    }

    /// <summary>
    /// Menu with instruction for adding animals.
    /// </summary>
    /// <param name="zoo"></param>
    private static void AddAnimalMenu(Zoo zoo)
    {
        Console.WriteLine("\n Choose a type of animal for adding:");
        Console.WriteLine("1. Monkey");
        Console.WriteLine("2. Rabbit");
        Console.WriteLine("3. Tiger");
        Console.WriteLine("4. Wolf");
        
        Console.Write("Enter a number of type: ");
        string option = Console.ReadLine();

        Animal animal;
        
        switch (option)
        {
            case "1":
                Console.WriteLine("Enter the name of monkey: ");
                string nameMonkey = Console.ReadLine();
                animal = new Monkey(nameMonkey ?? "monkey");
                break;
            case "2":
                Console.WriteLine("Enter the name of rabbit: ");
                string nameRabbit = Console.ReadLine();
                animal = new Rabbit(nameRabbit ?? "rabbit");
                break;
            case "3":
                Console.WriteLine("Enter the name of tiger: ");
                string nameTiger = Console.ReadLine();
                animal = new Tiger(nameTiger ?? "tiger");
                break;
            case "4":
                Console.WriteLine("Enter the name of wolf: ");
                string nameWolf = Console.ReadLine();
                animal = new Wolf(nameWolf ?? "wolf");
                break;
            default:
                Console.WriteLine("Invalid option");
                Console.Write("Touch enter to return to Main menu");
                Console.ReadLine();
                return;
        }

        Console.Write("Enter amount of food (kg/day): ");
        if (int.TryParse(Console.ReadLine(), out int food))
        {
            animal.Food = food;
        }
        else 
        { 
            Console.WriteLine("Invalid input!"); 
            Console.Write("Touch enter to return to Main menu");
            Console.ReadLine();
            return;
        }
        
        Console.Write("Enter the age of animal: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            animal.Age = age;
        }
        else
        {
            Console.WriteLine("Invalid input!"); 
            Console.Write("Touch enter to return to Main menu");
            Console.ReadLine();
            return;
        }
        
        Console.Write("Enter the temperature of animal: ");
        if (double.TryParse(Console.ReadLine(), out double temperature))
        {
            animal.BodyTemperature = temperature;
        }
        else
        {
            Console.WriteLine("Invalid input!");
            Console.Write("Touch enter to return to Main menu");
            Console.ReadLine();
            return;
        }
        
        Console.Write("Enter the activity level of animal (range: 1-10): ");
        if (int.TryParse(Console.ReadLine(), out int level))
        {
            if (level >= 1 && level <= 10)
            {
                animal.ActivityLevel = level;
            }
            else
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Touch enter to return to Main menu");
                Console.ReadLine();
                return;
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
            Console.Write("Touch enter to return to Main menu");
            Console.ReadLine();
            return;
        }

        if (animal is Herbo herb)
        {
            Console.Write("Enter the level of kindness of the herb: ");
            if (int.TryParse(Console.ReadLine(), out int kindness))
            {
                if (level >= 1 && level <= 10)
                {
                    herb.Kindness = kindness;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.Write("Touch enter to return to Main menu");
                    Console.ReadLine();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Touch enter to return to Main menu");
                Console.ReadLine();
                return;
            }
        }
        
        zoo.AddAnimal(animal);
        Console.Write("Touch enter to return to Main menu");
        Console.ReadLine();
    }

    /// <summary>
    /// Menu with instruction for adding animals.
    /// </summary>
    /// <param name="zoo"></param>
    private static void AddThingMenu(Zoo zoo)
    {
        Console.WriteLine("\n Choose a type of thing:");
        Console.WriteLine("1. Table");
        Console.WriteLine("2. Computer");
        
        Console.Write("Enter a number of type: ");
        string option = Console.ReadLine();
        
        Thing thing;

        switch (option)
        {
            case "1":
                Console.WriteLine("Enter the name of the table: ");
                string nameTable = Console.ReadLine();
                thing = new Table(nameTable ?? "table");
                break;
            case "2":
                Console.WriteLine("Enter the name of the computer: ");
                string nameComputer = Console.ReadLine();
                thing = new Computer(nameComputer ?? "computer");
                break;
            default:
                Console.WriteLine("Invalid option");
                Console.Write("Touch enter to return to Main menu");
                Console.ReadLine();
                return;
        }
        
        zoo.AddThing(thing);
        Console.Write("Touch enter to return to Main menu");
        Console.ReadLine();
    }
}