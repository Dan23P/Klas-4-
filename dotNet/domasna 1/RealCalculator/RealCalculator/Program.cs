// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Please write a number with which you want to do a operation");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Now write the second number");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Now write which operation you want to do");
string operation = Console.ReadLine();

if (operation == "+")
{
    Console.WriteLine(num1 + num2);

}
else if (operation == "-")
{
    Console.WriteLine(num1 - num2);

}
else if (operation == "*")
{
    Console.WriteLine(num1 * num2);

}
else if (operation == "/")
{
    Console.WriteLine(num1 / num2);
}