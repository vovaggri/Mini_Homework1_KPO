namespace HW1.Domain.Animals;

public abstract class Herbo : Alive
{
    // Level of kindness. If > 5, people can touch it.
    public int Kindness { get; set; }
}