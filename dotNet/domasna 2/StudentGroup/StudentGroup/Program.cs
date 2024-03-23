// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] group1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] group2 = { "Jana", "Mare", "Dare", "Mirko", "Spirko",};


Console.WriteLine("Which group of students do you want to see?");
Console.WriteLine("Write 1 for group 1 and write 2 for group 2"); 
string chooser = Console.ReadLine();

if  (chooser == "1" || chooser == "2")
{
    if (chooser == "1")
    {
        Console.WriteLine("The students in group 1 are: ");
        foreach (string s in group1)
        {
            Console.WriteLine(s);
        }
    } else
    {
    Console.WriteLine("The students in group 2 are: ");
        foreach (string s in group2)
    {
        Console.WriteLine(s);
}
    }
} else
{
    Console.WriteLine("You have eneterd an unexpected input. Please try again and enter 1 or 2");
}