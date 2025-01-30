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
        while (Program.player.health > 0 && Program.)
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
}