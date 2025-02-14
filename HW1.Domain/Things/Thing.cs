namespace HW1.Domain.Things;

public abstract class Thing : IInventory
{
    public int Number { get; set; }
    public string Name { get; protected set; }
}