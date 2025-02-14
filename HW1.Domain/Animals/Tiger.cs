namespace HW1.Domain.Animals;

public class Tiger : Predator
{
    public Tiger(string name)
    {
        Name = name;
    }
    
    public override string Type => "Tiger";
}