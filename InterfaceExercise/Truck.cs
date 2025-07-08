using System;
namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public bool Is18Wheeler { get; set; }
    public bool IsHuge { get; set; }
    
    public int NumberOfWheels { get; set; }
    public int NumberOfDoors { get; set; }
    public int NumberOfEngine { get; set; }
    public int Mileage { get; set; }

    public string Slogan { get; set; }
    public string Name { get; set; }
    
    public void DisplayDetails()
    {
        Console.WriteLine($"Is18Wheeler: {Is18Wheeler}");
        Console.WriteLine($"IsHuge: {IsHuge}");
        Console.WriteLine($"NumberOfWheels: {NumberOfWheels}");
        Console.WriteLine($"NumberOfDoors: {NumberOfDoors}");
        Console.WriteLine($"NumberOfEngine: {NumberOfEngine}");
        Console.WriteLine($"Mileage: {Mileage}");
        Console.WriteLine($"Slogan: {Slogan}");
        Console.WriteLine($"Name: {Name}\n");
    }
}