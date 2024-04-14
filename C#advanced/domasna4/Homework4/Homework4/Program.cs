// See https://aka.ms/new-console-template for more information
using Homework4.Classes;

Console.WriteLine("Hello, World!");


var newCars = CarsData.Cars.Where(c => c.Origin == "Europe");
Console.WriteLine("Cars from Europe: ");
foreach (var car in newCars)
{
    Console.WriteLine(car.Model);
}
Console.WriteLine("");  
var sixCylinderCars = CarsData.Cars.Where(c => c.Cylinders > 6);
Console.WriteLine("Cars with more than 6 cylinders: ");
foreach (var car in sixCylinderCars)
{
    Console.WriteLine(car.Model);
}
Console.WriteLine("");
var highPwFourCil = CarsData.Cars.Where(c => c.Cylinders < 5 && c.HorsePower > 110.0);
Console.WriteLine("Cars with 4 cylinders or less and more than 110 horse power: ");
foreach (var car in highPwFourCil)
{
    Console.WriteLine(car.Model);
}
Console.WriteLine("");
var originCounter = CarsData.Cars.GroupBy(c => c.Origin)
                                 .Select(group => $"{group.Key} {group.Count()} Models");
Console.WriteLine("Car count by origin:");
foreach (var car in originCounter)
{
    Console.WriteLine(car);
}
Console.WriteLine("");
var highPoweredCars = CarsData.Cars.Where(c => c.HorsePower > 200);
var lowestMpg = highPoweredCars.Min(c => c.MilesPerGalon);
var lowestMpgModel = highPoweredCars.Where(c => c.MilesPerGalon == lowestMpg).Select(c => c.Model);
var highestMpg = highPoweredCars.Max(c => c.MilesPerGalon);
var highestMpgModel = highPoweredCars.Where(c => c.MilesPerGalon == highestMpg).Select(c => c.Model);
var averageMpg = highPoweredCars.Average(c => c.MilesPerGalon);
var averageMpgModel = highPoweredCars.Where(c => c.MilesPerGalon == averageMpg).Select(c => c.Model);
Console.WriteLine($"Lowest MPG: {string.Join(", ", lowestMpgModel)} with {lowestMpg}MPG");
Console.WriteLine($"Highest MPG: {string.Join(", ", highestMpgModel)} with {highestMpg}MPG");
Console.WriteLine($"Average MPG: {string.Join(", ", averageMpgModel)} with {averageMpg}MPG");