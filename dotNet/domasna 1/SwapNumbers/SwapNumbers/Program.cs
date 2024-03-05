// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Program for swaping numbers");
Console.WriteLine("Enter two numbers and they will swap places");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int helper = num1;
num1 = num2;
num2 = helper;
Console.WriteLine("The swap program works!");
Console.WriteLine("the variable num1 is now: " +  num1);
Console.WriteLine("the variable num2 is now: " + num2);