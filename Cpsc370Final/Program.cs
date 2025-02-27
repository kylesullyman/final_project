﻿using System.Diagnostics;
namespace Cpsc370Final;
class Program
{
    public static string playerName;
    public static string playerClass;
    public static int playerRoundDamage;
    public static int enemyRoundDamage;

    public static bool isGameRunning = false;

    public static int roomNumber = 1;

    public static int playerCooldownCount = 0;
    public static int enemyCooldownCount = 0;
    
    public static PlayerStats player;
    
    static void Main(string[] args)
    {
        /*if (args.Length < 1)
            Console.WriteLine("Usage: Cpsc370Final <arguments>");
        
        // you can delete this if/when you like
        ShowArguments(args);
        */
        Start start = new Start();
        start.BeginStartPhase();
        playerName = start.playerName;
        playerClass = start.classInput;

        // initialize player without constructor
        
        // call constructor based on enum
        switch (playerClass)
        {
            case("Warrior"):
                player = new PlayerStats(PlayerClass.Warrior);
                break;
            case("Barbarian"):
                player = new PlayerStats(PlayerClass.Barbarian);
                break;
            case("Wizard"):
                player = new PlayerStats(PlayerClass.Wizard);
                break;
            case("Assassin"):
                player = new PlayerStats(PlayerClass.Assassin);
                break;
        }
        
        isGameRunning = true;
        RunMainLoop();

    }

    // this is just an example of how to get the command
    // line arguments so you can use them
    private static void ShowArguments(string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine("  Argument " + i +": " + args[i]);
        }
    }

    private static void RunMainLoop()
    {
        while (isGameRunning)
        {
            CombatPhase combatPhase = new CombatPhase();
            roomNumber++;
        }
    } 
}