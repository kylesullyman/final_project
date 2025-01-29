namespace Cpsc370Final.Tests;





public class PlayerUnitTests
{
    [Fact]
    public void CreateWarriorTest()
    {

        PlayerStats stats = new PlayerStats(PlayerClass.Warrior);
        
        Assert.True(stats.health == 16);
        Assert.True(stats.damageDice == 8);
        
        Assert.True(stats.armorClass == 15);
    }
}