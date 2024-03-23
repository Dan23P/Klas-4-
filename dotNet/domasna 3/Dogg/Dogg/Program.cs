// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Dog dog = new Dog();

Console.WriteLine("Enter the dogs name: ");
dog.Name = Console.ReadLine();

Console.WriteLine("Enter the dogs breed: ");
dog.Breed = Console.ReadLine();

Console.WriteLine("Enter the dogs color: ");
dog.Color = Console.ReadLine();

Console.WriteLine("What action would you like the dog to do? ");
Console.WriteLine("To make the dog eat press 1, to make it paly press 2 and to make it chase its tail 3 ");
int action = int.Parse(Console.ReadLine());

Console.WriteLine("The details about the dog are");
Console.WriteLine($"Dog's name: {dog.Name}");
Console.WriteLine($"Dog's breed: {dog.Breed}");
Console.WriteLine($"Dog's color: {dog.Color}");
Console.WriteLine($"Right now the dog is  ");

if (action == 1)
{
    dog.Eat();
} else if (action == 2)
{
    dog.Play();
} else if (action == 3)
{
    dog.ChaseTail();
}
else
{
    Console.WriteLine("There was an error you didnt write the expected input");
}



public class Dog 
{
    public string Name { get; set; }
    public string Breed { get; set; }
    public string Color { get; set; }
    public void Eat ()
    {
        Console.WriteLine("The dog is now eating");
    }
    public void Play()
    {
        Console.WriteLine("The dog is now playing");
    }
    public void ChaseTail()
    {
        Console.WriteLine("The dog is now chasing its tail");
    }
}


