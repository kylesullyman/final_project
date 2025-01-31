namespace Cpsc370Final;

public class Enemy
{
    
    
    //MonsterStats: Health, DamageDice(amount of sides a dice has that reflects damage), DodgeChance, ArmorClass, SpecialDamage, SpecialCooldown

    
    public string name;
    public int health { get; set; }
    public int damage { get; set; }
    public int damageDice { get; set; }
    public int dodgeChance { get; set; }
    public int armorClass { get; set; }
    public int specialDamage { get; set; }
    public int specialCooldown { get; set; }
    

    public EnemyRoster enemyType;

//like the band
    public Enemy()
    {
        enemyType = GetRandomEnumValue<EnemyRoster>();
        SetStatsByType();
    }
    
    
    public T GetRandomEnumValue<T>() where T : Enum
    {
        Array values = Enum.GetValues(typeof(T));
        Random random = new Random();
        return (T)values.GetValue(random.Next(values.Length));
    }


    public void SetStatsByType()
    {
        switch (enemyType)
        {
            case EnemyRoster.Goblin:
                setStats("Dulberg the Goblin", 8, 3, 4, 4, 4, 4, 2);
                break;
            
            case EnemyRoster.Golem:
                setStats("Dylan the giant Golem", 16, 5, 4, 20, 10, 5, 3);
                break;
            
            case EnemyRoster.Lobster:
                setStats("Land Lobster", 10, 4, 8,2, 12, 4, 3);
                break;
            case EnemyRoster.Skelaton:
                setStats("Sir Rattlebones `mcGee", 10, 4, 6, 6, 8, 4, 3);
                break;
            case EnemyRoster.Spider:
                setStats("Massive fucking spider", 10, 3, 4, 6, 8, 4, 3);
                break;
            case EnemyRoster.FishGoblin:
                setStats("Fish Goblin", 12, 2, 4, 3, 8, 4, 3);
                break;
            case EnemyRoster.LesserDemon:
                setStats("Big Red Scary Demon", 16, 5, 8, 2, 7, 8, 5);
                break;
            
            default:
                setStats("Glitch Goblin", 8, 9999, 2, 2, 4, 4, 2);
                enemyType = EnemyRoster.Goblin;
                break;
            
            
        }
    }


    private void setStats(string name, int health, int damage, int DamageDice, int dodgeChance, int armorClass, int specialDamage,
        int specialCooldown)
    {
        this.name = name;
        this.health = health;
        this.damageDice = DamageDice;
        this.dodgeChance = dodgeChance;
        this.armorClass = armorClass;
        this.specialCooldown = specialCooldown;
        this.specialDamage = specialDamage;
    }
    
    
    
    
}