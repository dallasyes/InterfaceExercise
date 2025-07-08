using System;
using System.Runtime.CompilerServices;

namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    public bool HasTrunk { get; set; }
    public int NumberOfSeats { get; set; }
    
    public int NumberOfWheels { get; set; }
    public int NumberOfDoors { get; set; }
    public int NumberOfEngine { get; set; }
    public int Mileage { get; set; }

    public string Slogan { get; set; }
    public string Name { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Has Trunk: {HasTrunk}");
        Console.WriteLine($"NumberOfSeats: {NumberOfSeats}");
        Console.WriteLine($"NumberOfWheels: {NumberOfWheels}");
        Console.WriteLine($"NumberOfDoors: {NumberOfDoors}");
        Console.WriteLine($"NumberOfEngine: {NumberOfEngine}");
        Console.WriteLine($"Mileage: {Mileage}");
        Console.WriteLine($"Slogan: {Slogan}");
        Console.WriteLine($"Name: {Name}\n");
    }
}