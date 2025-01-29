namespace Cpsc370Final;
using System; 
// using Program.cs

public static class FailPhase
{
    public static void PlayerDefeated(string playerName, string playerClass)
    {
        Console.WriteLine($"{playerName} the {playerClass} has been defeated!");
        
    }

    public static void GameOverOptions()
    {
        Console.WriteLine("Game over! What would you like to do?");
        Console.WriteLine("1. Restart Game");
        Console.WriteLine("2. Exit");
        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                // RestartGame();
                break;
            case "2":
                // ExitGame();
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                GameOverOptions();
                break;
        }
        
    }

    private static void RestartGame()
    {
        Console.WriteLine("Restarting game...");
        // Game.StartNewGame()
    }

    private static void ExitGame()
    {
        Console.WriteLine("Exiting game, thank you for playing!");
        bool testGameEnded = true;
        Environment.Exit(0);
    }
}