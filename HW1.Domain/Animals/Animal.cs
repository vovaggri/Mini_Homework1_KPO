namespace HW1.Domain.Animals;

public abstract class Animal : IAnimal, IInventory
{
    public string Name { get; protected init; }
    public int Food { get; set; }
    public int Number { get; set; }
    public abstract string Type { get; }
    
    public int Age { get; set; }
    public double BodyTemperature { get; set; }
    public int ActivityLevel { get; set; }
}