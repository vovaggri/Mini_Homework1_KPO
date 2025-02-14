using HW1.Domain.Animals;

namespace HW1.Domain;

public interface IVetClinic
{
    bool CheckHealth(Alive alive);
}