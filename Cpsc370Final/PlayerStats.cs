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
    public int damageDice;
    public int dodgeChance;
    public int armorClass;
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
                SetStats(16, 8, 4, 15, 3);
                break;
            
            case(PlayerClass.Assassin):
                SetStats(7, 10, 8, 6, 2);
                break;
            
            case(PlayerClass.Wizard):

                break;
            case(PlayerClass.Barbarian):
                
                break;
        }
    }


    private void SetStats(int health, int damageDice, int dodgeChance, int armorClass, int specialCooldown)
    {
        this.health = health;
        this.damageDice = damageDice;
        this.dodgeChance = dodgeChance;
        this.armorClass = armorClass;
        this.specialCooldown = specialCooldown;
    }


   
    
    
    
    
    
    
    
    
}

