namespace Cpsc370Final;

public class CombatPhase
{
    public string chosenEnemy;

    public CombatPhase()
    {
        chosenEnemy = GetRandomEnemy().ToString();
        Console.WriteLine("You are fighting a " + chosenEnemy);
        Console.WriteLine("Enemy Stats:");
        PrintEnemyStats();
    }

    private EnemyRoster GetRandomEnemy()
    {
        Array values = Enum.GetValues(typeof(EnemyRoster));
        Random random = new Random();
        return (EnemyRoster)values.GetValue(random.Next(values.Length));
    }
    
    private void PrintEnemyStats()
    {
        Enemy enemy = new Enemy();
        Console.WriteLine("Enemy Name: " + enemy.Name);
        Console.WriteLine("Enemy Health: " + enemy.Health);
        Console.WriteLine("Enemy Damage Dice: " + enemy.DamageDice);
        Console.WriteLine("Enemy Dodge Chance: " + enemy.DodgeChance);
        Console.WriteLine("Enemy Armor Class: " + enemy.ArmorClass);
        Console.WriteLine("Enemy Special Damage: " + enemy.SpecialDamage);
        Console.WriteLine("Enemy Special Cooldown: " + enemy.SpecialCooldown);
    }
}