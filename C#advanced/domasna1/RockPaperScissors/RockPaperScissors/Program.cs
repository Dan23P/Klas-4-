// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Sources;
using RockPaperScissors;
Console.WriteLine("Hello, World!");


Console.WriteLine("Rock Paper Scissor game");
Console.WriteLine("Choose if you want to check the STATS, PLAY or EXIT by writing the word");
string choice = Console.ReadLine();

int score = 0;
int compScore = 0;

Random rndm = new Random();
while (choice.ToLower() != "play" && choice.ToLower() != "stats" && choice.ToLower() != "exit")
{
    Console.WriteLine("Please write STATS, PLAY or EXIT");
    choice = Console.ReadLine();
    if (choice.ToLower() == "play" || choice.ToLower() == "exit")
    { 
        break;
    } else
    {
        stats(score, compScore, choice);
    }
}
if (choice.ToLower () == "stats")
{
    stats(score, compScore, choice);

}

void gamePlay (string choice, ref int compScore, ref int score, Random rndm)
{
    if (choice.ToLower() == "play")
    {
        Console.WriteLine("Choose if you want to use ROCK PAPER or SCISSORS by writing it");
        string objct = Console.ReadLine();
        string computerChoice = "";
        switch (rndm.Next(1, 4))
        {
            case 1:
                computerChoice = "Rock";
                break;
            case 2:
                computerChoice = "Paper";
                break;
            case 3:
                computerChoice = "Scissor";
                break;
        } 
        if (objct.ToLower() == "rock" || objct.ToLower() == "scissors" || objct.ToLower() == "paper")
        {
            if ((objct.ToLower() == "rock" && computerChoice.ToLower() == "paper") || (objct.ToLower() == "scissors" && computerChoice.ToLower() == "rock")
            || (objct.ToLower() == "paper" && computerChoice.ToLower() == "scissors"))
            {
                Console.WriteLine($"The computer picked {computerChoice}");
                Console.WriteLine("You Lost");
                compScore++;
            }
            /*else if ((computerChoice.ToLower() == "rock" && objct.ToLower() == "paper") || (computerChoice.ToLower() == "scissors" && objct.ToLower() == "rock")
                || (computerChoice.ToLower() == "paper" && objct.ToLower() == "scissors"))
            {
                Console.WriteLine($"The computer picked {computerChoice}");
                Console.WriteLine("You Won");
                score++;
            }*/
            else if (objct.ToLower() == computerChoice.ToLower())
            {
                Console.WriteLine($"The computer also picked {computerChoice}");
                Console.WriteLine("It's a Draw");
            }
            else
            {
                Console.WriteLine($"The computer picked {computerChoice}");
                Console.WriteLine("You Won");
                score++;
            }
        }
        
        if (objct.ToLower() == "stats" || choice.ToLower() == "stats")
        {
            stats(score, compScore, choice);

        }
        else if (objct.ToLower() == "exit" || choice.ToLower() == "exit")
        {
            Environment.Exit(0);
        }
    }
}
    while (choice.ToLower() == "play")
    {
        gamePlay(choice, ref compScore, ref score, rndm);
    }
    void stats(int score, int compScore, string choice)
    {
        Console.WriteLine("Does it work");
        Console.WriteLine($"Your score is : {score}");
        Console.WriteLine($"The computer's score is : {compScore}");
        Console.WriteLine("Choose if you want to check the STATS, PLAY or EXIT by writing the word");
        choice = Console.ReadLine();
        if (choice.ToLower() == "stats") 
        {
             stats (score, compScore, choice);
        } else if (choice.ToLower() == "play")
        {
        gamePlay(choice, ref compScore, ref score, rndm);

        } else if (choice.ToLower() == "exit")
        {
        Environment.Exit(0);
        }
}   
