// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Write 4 numbers one after another and the program will print out the average number");
double num1 = Convert.ToDouble(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());
double num3 = Convert.ToDouble(Console.ReadLine());
double num4 = Convert.ToDouble(Console.ReadLine());
double average = (num1 + num2 + num3 + num4) / 4;
Console.WriteLine("The average is:" + average);
Console.ReadLine();