using System;
namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    public bool HasBigTires { get; set; }
    public bool IsBig { get; set; }
    
    public int NumberOfWheels { get; set; }
    public int NumberOfDoors { get; set; }
    public int NumberOfEngine { get; set; }
    public int Mileage { get; set; }

    public string Slogan { get; set; }
    public string Name { get; set; }
    
    public void DisplayDetails()
    {
        Console.WriteLine($"HasBigTires: {HasBigTires}");
        Console.WriteLine($"IsBig: {IsBig}");
        Console.WriteLine($"NumberOfWheels: {NumberOfWheels}");
        Console.WriteLine($"NumberOfDoors: {NumberOfDoors}");
        Console.WriteLine($"NumberOfEngine: {NumberOfEngine}");
        Console.WriteLine($"Mileage: {Mileage}");
        Console.WriteLine($"Slogan: {Slogan}");
        Console.WriteLine($"Name: {Name}\n");
    }
}