namespace Cpsc370Final.Tests;

public class CombatPhaseActions_Test
{
    [Theory]
    [InlineData(4,5)]
    public void AttackPhaseTest(int damage, int damageDice)
    {
        Assert.Equal(5,CombatPhaseActions.AttackDamage(damage,damageDice));
    }
}