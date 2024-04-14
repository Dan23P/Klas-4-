// See https://aka.ms/new-console-template for more information
using HomeWork3.Classes;

Console.WriteLine("Hello, World!");
Car car1 = new Car();
car1.Id = 1;
car1.Type = "Sedan";
car1.YearOfProduction = 2000;
car1.FuelTank = 50;
car1.CountriesProducedIn = new List<string> { "USA", " Germany"};


Bike bike1 = new Bike();
bike1.Id = 1;
bike1.Type = "Sport";
bike1.YearOfProduction = 2024;
bike1.Color = "Yellow";


DataBase.Vehicles.Add(car1);
DataBase.Vehicles.Add(bike1);

foreach (Vehicle vehicle in DataBase.Vehicles)
{
    vehicle.PrintVehicle();
}


Console.WriteLine($"Validation for car: {Validator.Validation(car1)}");
Console.WriteLine($"Validation for bike: {Validator.Validation(bike1)}");