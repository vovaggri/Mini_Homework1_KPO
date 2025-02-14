namespace HW1.Domain.Animals;

public abstract class Animal : IAnimal, IInventory
{
    public int Food { get; set; }
    public int Number { get; set; }
    public string Name { get; set; }
}