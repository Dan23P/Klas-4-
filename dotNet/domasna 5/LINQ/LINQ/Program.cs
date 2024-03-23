Console.WriteLine("Hello, World!");
List<int> numbers = new List<int>() { 14, 22, 13, 91, 5, 65, 21, 38, 966, 54 };
var squares = numbers.Select(x => x * x).ToList();
foreach (var square in squares)
{
    Console.WriteLine(square);
}
Console.ReadKey();