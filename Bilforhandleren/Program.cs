using Bilforhandleren;
using System;

class Program
{
    static void Main()
    {
        Dealership dealership = new Dealership();

        dealership.AddCar(new Car { Brand = "BMW", Year = 2022, RegistrationNumber = "ABC123", Kilometer = 10000 });
        dealership.AddCar(new Car { Brand = "Audi", Year = 2021, RegistrationNumber = "XYZ789", Kilometer = 15000 });

        dealership.DisplayAvailableCars();
    }
}