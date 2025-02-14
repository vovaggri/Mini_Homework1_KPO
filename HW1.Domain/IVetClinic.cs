using HW1.Domain.Animals;

namespace HW1.Domain;

public interface IVetClinic
{
    bool CheckHealth(Animal animal);
}