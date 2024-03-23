// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string number = Console.ReadLine();
void SumOfNumbers(string number)
{
    int number2 = int.Parse(number);
    int theSum = 0;
    foreach (char i in number)
    {   int j = int.Parse(i.ToString());
        theSum +=j;
    }
    Console.WriteLine(theSum);
}
SumOfNumbers(number);
