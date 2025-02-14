namespace HW1.Domain.Animals;

public class Wolf : Predator
{
    public Wolf(string name)
    {
        Name = name;
    }
    
    public override string Type => "Wolf";
}