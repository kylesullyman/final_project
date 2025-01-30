namespace Cpsc370Final;

public class CombatPhase
{
    public Enemy enemy;
    public CombatPhase()
    {
        enemy = new Enemy();
        Console.WriteLine("You are fighting a " + enemy.name);
        Console.WriteLine("Enemy Stats:");
        PrintEnemyStats();
        RunCombatPhaseLoop();
    }

    private EnemyRoster GetRandomEnemy()
    {
        Array values = Enum.GetValues(typeof(EnemyRoster));
        Random random = new Random();
        return (EnemyRoster)values.GetValue(random.Next(values.Length));
    }
    
    private void PrintEnemyStats()
    {
        Console.WriteLine("Enemy Name: " + enemy.name);
        Console.WriteLine("Enemy Health: " + enemy.health);
        Console.WriteLine("Enemy Damage Dice: " + enemy.damageDice);
        Console.WriteLine("Enemy Dodge Chance: " + enemy.dodgeChance);
        Console.WriteLine("Enemy Armor Class: " + enemy.armorClass);
        Console.WriteLine("Enemy Special Damage: " + enemy.specialDamage);
        Console.WriteLine("Enemy Special Cooldown: " + enemy.specialCooldown);
    }


    private void RunCombatPhaseLoop()
    {
        bool isCombatRunning = true;
        // 0 is player turn, 1 is enemy turn
        int playerTurn = 0;

        while (isCombatRunning)
        {
            if (playerTurn == 0)
            {
                string choice = GetPlayerChoice();
                ExecutePlayerChoice(choice);
            }
            else
            {
                string choice = GetAIChoice();
            }
        }
    }

    private string GetPlayerChoice()
    {
        string output = "";

        while (true)
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Special");
            Console.WriteLine("3. Dodge");
            output = Console.ReadLine();
            if(output == "1" ||  output == "2" || output == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }

        return output;
    }

    private string GetAIChoice()
    {
        string output = "";
        
        Random random = new Random();
        int choice = random.Next(3);
        
        switch (choice)
        {
            case 0:
                output = "attack";
                break;
            case 1:
                output = "special";
                break;
            case 2:
                output = "dodge";
                break;
        }

        return output;
    }
    
    private void ExecutePlayerChoice(string choice)
    {
        switch (choice)
        {
            case "1":
                Console.WriteLine("You chose to attack!");
               Program.playerRoundDamage = CombatPhaseActions.AttackDamage(1, Program.player.damageDice);
                enemy.health -= attackDamage;
                CombatMessages.PlayerAttackText(attackDamage);
                break;
            case "2":
                Console.WriteLine("You chose to use your special!");
                break;
            case "3":
                Console.WriteLine("You chose to dodge!");
                break;
        }
    }
}