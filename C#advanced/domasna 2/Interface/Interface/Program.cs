// See https://aka.ms/new-console-template for more information
using Interface.Classes;

Console.WriteLine("Hello, World!");
Console.WriteLine("Your animals are:");
Console.WriteLine("");
Cat cat1 = new Cat ();
cat1.Name = "Kitty";
cat1.Age = 11;
cat1.PrintAnimal();
Console.WriteLine("");
cat1.Eat("Tuna");
Console.WriteLine("");

Cat cat2 = new Cat ();
cat2.Name = "Mimi";
cat2.Age = 2;
cat2.PrintAnimal();
Console.WriteLine("");
cat2.Eat("Salami");
Console.WriteLine("");

Dog dog1 = new Dog ();
dog1.Name = "Aron";
dog1.Age = 11;
dog1.PrintAnimal();
Console.WriteLine("");
dog1.Bark();
Console.WriteLine("");


Dog dog2 = new Dog ();
dog2.Name = "Max";
dog2.Age = 7;
dog2.PrintAnimal();
Console.WriteLine("");
dog2.Bark();
Console.WriteLine("");

Dog dog3 = new Dog();
dog3.Name = "Monte";
dog3.Age = 7;
dog3.PrintAnimal();
Console.WriteLine("");
dog3.Bark();