namespace HW1.Domain.Animals;

public class Rabbit : Herbo
{
    public Rabbit(string name)
    {
        Name = name;
    }
    
    public override string Type => "Rabbit";
}