// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Eneter a sentece");
string sentenceStrng = Console.ReadLine();

string[] multipleWords = sentenceStrng.Split(' ');

Console.WriteLine("The words from your sentence are:");

foreach (string word in multipleWords)
{
    Console.WriteLine(word);
}
Console.ReadLine();