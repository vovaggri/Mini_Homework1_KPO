using HW1.Domain.Animals;

namespace HW1.Domain.VetClinic;

public class VetClinic : IVetClinic
{
    public bool CheckHealth(Alive alive)
    {
        int score = CalculateHealthScore(alive);
        Console.WriteLine($"Health check: {alive.Type}, {alive.Name}: {score}");
        // If score >= 6, the animal is healthy.
        return score >= 6;
    }

    private int CalculateHealthScore(Alive alive)
    {
        int score = 0;
        
        // Age (the best age range is 2...8).
        if (alive.Age >= 2 && alive.Age <= 8)
        {
            score += 3;
        }
        else if (alive.Age < 2)
        {
            score += 2;
        }
        else
        {
            score += 1;
        }
        
        // Temperature (the best range is 38-39).
        if (alive.BodyTemperature >= 38 && alive.BodyTemperature <= 39)
        {
            score += 2;
        }
        else
        {
            score += 1;
        }
        
        // Activity Level (range: 1...10; >=5 is good).
        if (alive.ActivityLevel >= 5)
        {
            score += 2;
        }
        else
        {
            score += 1;
        }

        return Math.Min(score, 10);
    }
}