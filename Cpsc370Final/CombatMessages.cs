namespace Cpsc370Final;

public static class CombatMessages
{
    public static void PlayerAndEnemyAttack(int playerDamage, int enemyDamage)
    {
        Console.WriteLine(PlayerAttackText(playerDamage));
        Console.WriteLine(EnemyAttackText(enemyDamage));
    }

    public static void PlayerAndEnemyDodge()
    {
        Console.WriteLine("Player dodges");
        Console.WriteLine("Enemy dodges");
    }

    public static void PlayerAndEnemySpecial(int playerDamage, int enemyDamage)
    {
        Console.WriteLine(PlayerSpecialText(playerDamage));
        Console.WriteLine(EnemySpecialText(enemyDamage));
    }

    public static string PlayerAttackText(int playerDamage)
    {
        return("Player attacks and deals " + playerDamage + " damage");
    }

    public static string EnemyAttackText(int enemyDamage)
    {
        return("Enemy attacks and deals " + enemyDamage + " damage");
    }

    public static string PlayerSpecialText(int playerDamage)
    {
        return ("Player uses Special and deals " + playerDamage + " damage");
    }
    public static string EnemySpecialText(int enemyDamage)
    {
        return ("Enemy uses Special and deals " + enemyDamage + " damage");
    }

    public static string PlayerDodgeSucceed()
    {
        return ("Player Dodged");
    }
    public static string PlayerDodgeFail()
    {
        return ("Player failed to Dodge");
    }
    public static string EnemyDodgeSucceed()
    {
        return ("Enemy Dodged");
    }
    public static string EnemyDodgeFail()
    {
        return ("Enemy failed to Dodge");
    }

    public static string PlayerAttackFail()
    {
        return ("Player failed to hit");
    }
    public static string EnemyAttackFail()
    {
        return ("Enemy failed to hit");
    }
    
    
}