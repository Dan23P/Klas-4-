// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Ebter your birthdate: ");
string birthDate =  Console.ReadLine();

static void AgeCalculator (string birthDate)
{
    DateTime currentDay = DateTime.Today;
    DateTime convertedDate = DateTime.Parse(birthDate);
    int age = currentDay.Year - convertedDate.Year;

    age = (convertedDate > currentDay.AddYears(-age)) ? age - 1 : age;
    Console.WriteLine($"Your age is: " + age);
}
AgeCalculator(birthDate);