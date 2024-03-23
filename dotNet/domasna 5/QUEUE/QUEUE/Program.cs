Console.WriteLine("Hello, World!");
Console.WriteLine("Enter numbers in the Queue by entering one number than choosing if you want to enter another " +
    "by entering Y for yes and N for no if you are done adding numbers");
string yesNo = "Y";

Queue<int> theQueue = new Queue<int>();
do
{
    Console.WriteLine("Enter a number");
    //int number = int.Parse(Console.ReadLine());
    int number; 
    if (int.TryParse(Console.ReadLine(), out number))
    {
        theQueue.Enqueue(number);
        Console.WriteLine("Do you want to continue. Write Y for yes and N for No");
        yesNo = Console.ReadLine().ToUpper();
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        
        //yesNo = "Y";

    }
} while (yesNo == "Y");

foreach (int num in theQueue)
{
    Console.WriteLine(num);
}