namespace Cpsc370Final;



public class PlayerStats
{
    
    
    
    /*Class Options: Warrior, Barbarian, Wizard, Assassin

        Player Stats: Health, 
    Damage(amount of damage guaranteed when attacking), 
    DamageDice(amount of sides a dice has that represents damage added onto base damage), 
    DodgeChance(user inputs a number and if it is higher or lower than a certain number, they dodge), 
    ArmorClass(amount of damage an attack needs to be to be able to hit), SpecialDamage, 
    SpecialCooldown(x amount of rounds/attacks)*/

    
    
    public int health;
    public int damage;
    public int damageDice;
    public int dodgeChance;
    public int armorClass;
    public int specialDamage;
    public int specialCooldown;
    
    
    private PlayerClass playerClass;
    
   
    
    


    public PlayerStats(PlayerClass playerClass)
    {
        this.playerClass = playerClass;
        SetClassStats();
        
    }


    public void SetClassStats()
    {
        switch (playerClass)
        {
            case(PlayerClass.Warrior):
                SetStats(16, 5, 8, 5, 14, 3, 8);
                break;
            
            case(PlayerClass.Assassin):
                SetStats(8, 6, 10, 2, 8, 3, 10);
                break;
            
            case(PlayerClass.Wizard):
                SetStats(6,  5,6, 3, 6, 2, 15);
                break;
            case(PlayerClass.Barbarian):
                SetStats(12, 4, 10, 3, 8, 2, 9);
                break;
        }
    }


    private void SetStats(int health, int damage, int damageDice, int dodgeChance, int armorClass, int specialCooldown, int specialDamage)
    {
        this.health = health;
        this.damage = damage;
        this.damageDice = damageDice;
        this.dodgeChance = dodgeChance;
        this.armorClass = armorClass;
        this.specialDamage = specialDamage;
        this.specialCooldown = specialCooldown;
    }


   
    
    
    
    
    
    
    
    
}

