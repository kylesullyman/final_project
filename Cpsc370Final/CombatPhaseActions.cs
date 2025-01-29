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
}