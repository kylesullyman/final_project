namespace Cpsc370Final;

public class WinState
{
    public void PlayerVictory(string playerName, string playerClass)
    {
        Console.WriteLine($"Congratulations, {playerName} the {playerClass} wins!");
        VictoryOptions();
    }

    public void VictoryOptions()
    {


        Console.WriteLine(@"            .-""""""""-.");
        Console.WriteLine(@"          .'          '.");
        Console.WriteLine(@"         /   O      O   \");
        Console.WriteLine(@"        :                :");
        Console.WriteLine(@"        |                |");
        Console.WriteLine(@"        : ',          ,' :");
        Console.WriteLine(@"         \  '-......-'  /");
        Console.WriteLine(@"          '.          .'");
        Console.WriteLine(@"            '-......-'");
        Console.WriteLine("You won the game! What would you like to do next?");
        Console.WriteLine("1. Play Again");
        Console.WriteLine("2. Exit");
        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                //Game.StartNewGame()
                break;
            case "2":
                Console.WriteLine("Thanks for playing!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid option, please select a valid number.");
                VictoryOptions();
                break;
        }

        
        



    }
}