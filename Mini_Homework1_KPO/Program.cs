using HW1.Domain.Zoo;
using HW1.Domain;
using Microsoft.Extensions.DependencyInjection;
using MenuLibrary;

namespace Mini_Homework1_KPO;

class Program
{
    static void Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();
        ConfigureServices.ConfigureServicesServices(serviceCollection);
        var serviceProvider = serviceCollection.BuildServiceProvider();
        
        var zoo = serviceProvider.GetService<Zoo>();
        if (zoo == null)
        {
            Console.WriteLine("Error of initializing Zoo");
            return;
        }

        Menu.MenuMain(zoo);

        Console.WriteLine("Shutting down app.");
    }
}