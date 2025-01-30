namespace Cpsc370Final;

public class Enemy
{
    
    
    //MonsterStats: Health, DamageDice(amount of sides a dice has that reflects damage), DodgeChance, ArmorClass, SpecialDamage, SpecialCooldown

    
    public string Name;
    public int Health { get; set; }
    public int DamageDice { get; set; }
    public int DodgeChance { get; set; }
    public int ArmorClass { get; set; }
    public int SpecialDamage { get; set; }
    public int SpecialCooldown { get; set; }

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
                setStats("Goblin", 8, 2, 2, 4, 4, 2);
                break;
            
            case EnemyRoster.Golem:
                setStats("Golem", 16, 3, 1, 10, 5, 3);
                break;
            
            default:
                setStats("Goblin", 8, 2, 2, 4, 4, 2);
                enemyType = EnemyRoster.Goblin;
                break;
            
        }
    }


    private void setStats(string name, int health, int DamageDice, int dodgeChance, int armorClass, int specialDamage,
        int specialCooldown)
    {
        Name = name;
        Health = health;
        this.DamageDice = DamageDice;
        this.DodgeChance = dodgeChance;
        ArmorClass = armorClass;
        SpecialDamage = specialDamage;
    }
    
    
    
    
}