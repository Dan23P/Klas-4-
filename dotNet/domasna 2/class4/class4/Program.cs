// See https://aka.ms/new-console-template for more information
using System.Runtime.ExceptionServices;

Console.WriteLine("Hello, World!");
Console.WriteLine("Write one word with more than 5 characters");
string firstString  = Console.ReadLine();
if (firstString == null || firstString.Length < 6)
{
    Console.WriteLine("You have not enetered a word with al least 6 characters. Please try again");
} else
{
         string newString = firstString.Substring(firstString.Length - 5);
    Console.WriteLine("Last 5 letters from your string are: " + newString);
}
Console.ReadLine();