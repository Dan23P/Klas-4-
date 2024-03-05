// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Write 4 numbers one after another and the program will print out the average number");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int num4 = Convert.ToInt32(Console.ReadLine());
int average = (num1 + num2 + num3 + num4) / 4;
Console.WriteLine("The average is:" + average);
