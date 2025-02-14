using HW1.Domain.Animals;

namespace HW1.Domain;

public class Monkey : Herbo
{
    public Monkey(string name)
    {
        Name = name;
    }
    
    public override string Type => "Monkey";
}