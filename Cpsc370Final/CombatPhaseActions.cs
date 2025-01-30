using System.Net.Http.Headers;

namespace Cpsc370Final;

public static class CombatPhaseActions
{
    public static int AttackDamage(int damage, int damageDice)
    {
        Random random = new Random();
        int randomDamageNumber = random.Next(1, damageDice);
        int damageToReturn = damage + randomDamageNumber;
        return damageToReturn;
    }

    public static bool PlayerCanDodge(int dodgeChance)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, dodgeChance);
        int choice = GetPlayerInput(dodgeChance);
        if (randomNumber == choice)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool EnemyCanDodge(int dodgeChance)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, dodgeChance);
        int enemyGuess = random.Next(1, dodgeChance);
        if (enemyGuess == randomNumber)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static int GetPlayerInput(int dodgeChance)
    {
        int result;
        while (true)
        {
            Console.Write("Choose a number between 1 and " + dodgeChance +"");
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("That's not a valid number. Please try again.");
            }
        }
    }
}