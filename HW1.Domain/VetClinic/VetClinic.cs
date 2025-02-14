using HW1.Domain.Animals;

namespace HW1.Domain.VetClinic;

public class VetClinic : IVetClinic
{
    public bool CheckHealth(Animal animal)
    {
        int score = CalculateHealthScore(animal);
        Console.WriteLine($"Health check: {animal.Type}, {animal.Name}: {score}");
        // If score >= 6, the animal is healthy.
        return score >= 6;
    }

    private int CalculateHealthScore(Animal animal)
    {
        int score = 0;
        
        // Age (the best age range is 2...8).
        if (animal.Age >= 2 && animal.Age <= 8)
        {
            score += 3;
        }
        else if (animal.Age < 2)
        {
            score += 2;
        }
        else
        {
            score += 1;
        }
        
        // Temperature (the best range is 38-39).
        if (animal.BodyTemperature >= 38 && animal.BodyTemperature <= 39)
        {
            score += 2;
        }
        else
        {
            score += 1;
        }
        
        // Activity Level (range: 1...10; >=5 is good).
        if (animal.ActivityLevel >= 5)
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