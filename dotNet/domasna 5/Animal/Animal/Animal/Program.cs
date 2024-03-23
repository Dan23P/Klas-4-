// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Reflection;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");
List<Animal> animals = new List<Animal>
{
    new Animal { Name = "Dog", Color = "Brown", Age = 3, Gender = Gender.Male },
    new Animal { Name = "Cat", Color = "White", Age = 6, Gender = Gender.Female },
    new Animal { Name = "Elephant", Color = "Gray", Age = 10, Gender = Gender.Male },
    new Animal { Name = "Ant", Color = "Black", Age = 1, Gender = Gender.Female },
    new Animal { Name = "Antilope", Color = "Brown", Age = 5, Gender = Gender.Male },
    new Animal { Name = "Tiger", Color = "Orange", Age = 8, Gender = Gender.Male },
    new Animal { Name = "Lion", Color = "Yellow", Age = 6, Gender = Gender.Male },
    new Animal { Name = "Crocodile", Color = "Green", Age = 12, Gender = Gender.Female },
    new Animal { Name = "Hippopotamus", Color = "Gray", Age = 30, Gender = Gender.Female },

};
Console.WriteLine("=================");
var animalAgeName = animals.Where(Animal => Animal.Age >= 5).Select(Animal  => Animal.Name).ToList();
foreach (var name in animalAgeName)
{
    Console.WriteLine(name);
}
Console.WriteLine("=================");
var animalNameA = animals.Where(Animal => Animal.Name.StartsWith("A")).Select(Animal =>Animal.Name).ToList();
foreach (var name in animalNameA)
{
    Console.WriteLine(name);
}
Console.WriteLine("=================");
var maleAnimals = animals.Where(Animal => Animal.Gender == Gender.Male && Animal.Color == "Brown").Select(Animal => Animal.Name).ToList();
foreach (var name in maleAnimals)
{
    Console.WriteLine(name);
}
Console.WriteLine("=================");
var longName = animals.FirstOrDefault(Animal => Animal.Name.Length > 10);
if (longName != null)
{
    Console.WriteLine(longName.Name);
}
else
{
    Console.WriteLine("No animal found with a name longer than 10 characters.");
}

public class Animal
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }
}

public enum Gender
{
    Male,
    Female,
}