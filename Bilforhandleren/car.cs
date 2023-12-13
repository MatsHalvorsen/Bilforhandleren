namespace Bilforhandleren;

public class Car
{
    public string? Brand { get; set; }
    public int Year { get; set; }
    public string? RegistrationNumber { get; set; }
    public int Kilometer { get; set; }

    public override string ToString()
    {
        return $"Brand: {Brand}\nYear: {Year}\nRegistrationNumber: {RegistrationNumber}\nKilometer: {Kilometer} km\n";
    }

}


    public class Dealership
{
    private List<Car> cars = new List<Car>();
    public void AddCar(Car car)
    {
        cars.Add(car);
    }


public void DisplayAvailableCars()
    {
        Console.WriteLine("Available cars:");
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
