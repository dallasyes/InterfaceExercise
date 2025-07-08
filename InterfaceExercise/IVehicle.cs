namespace InterfaceExercise;

public interface IVehicle
{
    public int NumberOfWheels { get; set; }
    public int NumberOfDoors { get; set; }
    public int NumberOfEngine { get; set; }
    public int Mileage { get; set; }

    public void DisplayDetails();
}