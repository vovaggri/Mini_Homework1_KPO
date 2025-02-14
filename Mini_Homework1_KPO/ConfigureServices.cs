using HW1.Domain;
using HW1.Domain.NumberGenerator;
using HW1.Domain.VetClinic;
using HW1.Domain.Zoo;
using Microsoft.Extensions.DependencyInjection;

namespace Mini_Homework1_KPO;

public static class ConfigureServices
{
    public static void ConfigureServicesServices(IServiceCollection services)
    {
        services.AddSingleton<IVetClinic, VetClinic>();
        services.AddSingleton<IInventoryNumberGenerator, InventoryNumberGenerator>();
        services.AddSingleton<Zoo>();
    }
}