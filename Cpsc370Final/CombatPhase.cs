namespace Cpsc370Final;

public class CombatPhase
{
    public Enemy enemy;
    public CombatPhase()
    {
        enemy = new Enemy();
        Console.WriteLine("You are fighting a " + enemy.name);
        Console.WriteLine("Enemy Stats:");
        PrintEnemyStats();
        RunCombatPhaseLoop();
    }

    private EnemyRoster GetRandomEnemy()
    {
        Array values = Enum.GetValues(typeof(EnemyRoster));
        Random random = new Random();
        return (EnemyRoster)values.GetValue(random.Next(values.Length));
    }
    
    private void PrintEnemyStats()
    {
        Console.WriteLine("Enemy Name: " + enemy.name);
        Console.WriteLine("Enemy Health: " + enemy.health);
        Console.WriteLine("Enemy Damage Dice: " + enemy.damageDice);
        Console.WriteLine("Enemy Dodge Chance: " + enemy.dodgeChance);
        Console.WriteLine("Enemy Armor Class: " + enemy.armorClass);
        Console.WriteLine("Enemy Special Damage: " + enemy.specialDamage);
        Console.WriteLine("Enemy Special Cooldown: " + enemy.specialCooldown);
    }


    private void RunCombatPhaseLoop()
    {
        Program.playerCooldownCount = Program.player.specialCooldown;
        Program.enemyCooldownCount = enemy.specialCooldown;
        while (Program.player.health > 0 && enemy.health > 0)
        {
            string playerChoice = GetPlayerChoice();
            string enemyChoice = GetAIChoice();
            if (playerChoice == "attack" && enemyChoice == "attack")
            {
                GetPlayerRoundDamage();
                GetEnemyRoundDamage();
                if (Program.playerRoundDamage >= enemy.armorClass)
                {
                    EnemyTakesDamage(Program.playerRoundDamage);
                    Console.WriteLine(CombatMessages.PlayerAttackText(Program.playerRoundDamage));
                }
                else
                {
                    Console.WriteLine(CombatMessages.PlayerAttackFail());
                }
                if (Program.enemyRoundDamage >= Program.player.armorClass)
                {
                    PlayerTakesDamage(Program.enemyRoundDamage);
                    Console.WriteLine(CombatMessages.EnemyAttackText(Program.enemyRoundDamage));
                }
                else
                {
                    Console.WriteLine(CombatMessages.EnemyAttackFail());
                }
            }
            else if (playerChoice == "dodge" && enemyChoice == "dodge")
            {
                CombatMessages.PlayerAndEnemyDodge();
            }
            else if (playerChoice == "special" && enemyChoice == "special")
            {
                if (CheckPlayerSpecialCooldown())
                {
                    EnemyTakesDamage(Program.player.specialDamage);
                    Console.WriteLine(CombatMessages.PlayerSpecialText(Program.player.specialDamage));
                }

                if (CheckEnemySpecialCooldown())
                {
                    PlayerTakesDamage(enemy.specialDamage);
                    Console.WriteLine(CombatMessages.EnemySpecialText(enemy.specialDamage));
                }
            }
            else if (playerChoice == "attack" && enemyChoice == "dodge")
            {
                if (CombatPhaseActions.EnemyCanDodge(enemy.dodgeChance))
                {
                    Console.WriteLine("Player tried to attack");
                    Console.WriteLine(CombatMessages.EnemyDodgeSucceed());
                }
                else
                {
                    Console.WriteLine("Player tried to attack");
                    GetPlayerRoundDamage();
                    Console.WriteLine(CombatMessages.EnemyDodgeFail());
                    EnemyTakesDamage(Program.playerRoundDamage);
                    Console.WriteLine(CombatMessages.PlayerAttackText(Program.playerRoundDamage));
                }
            }
            else if (playerChoice == "attack" && enemyChoice == "special")
            {
                GetPlayerRoundDamage();
                if (Program.playerRoundDamage >= enemy.armorClass)
                {
                    EnemyTakesDamage(Program.playerRoundDamage);
                    Console.WriteLine(CombatMessages.PlayerAttackText(Program.playerRoundDamage));
                }
                else
                {
                    Console.WriteLine(CombatMessages.PlayerAttackFail());
                }
                if (CheckEnemySpecialCooldown())
                {
                    PlayerTakesDamage(enemy.specialDamage);
                    Console.WriteLine(CombatMessages.EnemySpecialText(enemy.specialDamage));
                }
            }
            else if (playerChoice == "dodge" && enemyChoice == "attack")
            {
                if (CombatPhaseActions.PlayerCanDodge(Program.player.dodgeChance))
                {
                    Console.WriteLine("Enemy tried to attack");
                    Console.WriteLine(CombatMessages.PlayerDodgeSucceed());
                }
                else
                {
                    Console.WriteLine("Enemy tried to attack");
                    GetEnemyRoundDamage();
                    Console.WriteLine(CombatMessages.PlayerDodgeFail());
                    PlayerTakesDamage(Program.enemyRoundDamage);
                    Console.WriteLine(CombatMessages.EnemyAttackText(Program.enemyRoundDamage));
                }
            }
            else if (playerChoice == "dodge" && enemyChoice == "special")
            {
                if (CombatPhaseActions.PlayerCanDodge(Program.player.dodgeChance))
                {
                    Console.WriteLine("Enemy tried to use special");
                    Console.WriteLine(CombatMessages.PlayerDodgeSucceed());
                }
                else
                {
                    Console.WriteLine("Enemy tried to use special");
                    Console.WriteLine(CombatMessages.PlayerDodgeFail());
                    if (CheckEnemySpecialCooldown())
                    {
                        PlayerTakesDamage(enemy.specialDamage);
                        Console.WriteLine(CombatMessages.EnemySpecialText(enemy.specialDamage));
                    }
                }
            }
            else if (playerChoice == "special" && enemyChoice == "attack")
            {
                GetEnemyRoundDamage();
                if (CheckPlayerSpecialCooldown())
                {
                    EnemyTakesDamage(Program.player.specialDamage);
                    Console.WriteLine(CombatMessages.PlayerSpecialText(Program.player.specialDamage));
                }
                if (Program.enemyRoundDamage >= Program.player.armorClass)
                {
                    PlayerTakesDamage(Program.enemyRoundDamage);
                    Console.WriteLine(CombatMessages.EnemyAttackText(Program.enemyRoundDamage));
                }
                else
                {
                    Console.WriteLine(CombatMessages.EnemyAttackFail());
                }
            }
            else if (playerChoice == "special" && enemyChoice == "dodge")
            {
                if (CombatPhaseActions.EnemyCanDodge(enemy.dodgeChance))
                {
                    Console.WriteLine("Player tried to use special");
                    Console.WriteLine(CombatMessages.EnemyDodgeSucceed());
                }
                else
                {
                    Console.WriteLine("Player tried to use special");
                    Console.WriteLine(CombatMessages.EnemyDodgeFail());
                    if (CheckPlayerSpecialCooldown())
                    {
                        EnemyTakesDamage(Program.player.specialDamage);
                        Console.WriteLine(CombatMessages.PlayerSpecialText(Program.player.specialDamage));
                    }
                }
            }
            Console.WriteLine("Player health: "+ Program.player.health);
            Console.WriteLine("Enemy health: "+ enemy.health);

            Program.enemyCooldownCount += 1;
            Program.playerCooldownCount += 1;
            Program.playerRoundDamage = 0;
            Program.enemyRoundDamage = 0;
        }

        if (Program.player.health <= 0)
        {
            FailPhase.PlayerDefeated(Program.playerName, Program.playerClass);
            FailPhase.GameOverOptions();
        }

        if (enemy.health <= 0)
        {
            Console.WriteLine("You defeated " + enemy.name);
        }
    }

    private void GetPlayerRoundDamage()
    {
        Program.playerRoundDamage = CombatPhaseActions.AttackDamage(Program.player.damage, Program.player.damageDice);
    }
    private void GetEnemyRoundDamage()
    {
        Program.enemyRoundDamage = CombatPhaseActions.AttackDamage(enemy.damage, enemy.damageDice);
    }

    private bool CheckPlayerSpecialCooldown()
    {
        if (Program.playerCooldownCount >= Program.player.specialCooldown)
        {
            Program.playerCooldownCount = 0;
            return true;
        }
        else
        {
            Console.WriteLine("Player Special is still on cooldown");
            return false;
        }
    }
    private bool CheckEnemySpecialCooldown()
    {
        if (Program.enemyCooldownCount >= enemy.specialCooldown)
        {
            Program.enemyCooldownCount = 0;
            return true;
        }
        else
        {
            Console.WriteLine("Enemy Special is still on cooldown");
            return false;
        }
    }

    private void PlayerTakesDamage(int damage)
    {
        Program.player.health -= damage;
    }
    private void EnemyTakesDamage(int damage)
    {
        enemy.health -= damage;
    }

    private string GetPlayerChoice()
    {
        string output = "";

        while (true)
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. attack");
            Console.WriteLine("2. special");
            Console.WriteLine("3. dodge");
            output = Console.ReadLine();
            if(output == "attack" ||  output == "special" || output == "dodge")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }

        return output;
    }

    private string GetAIChoice()
    {
        string output = "";
        
        Random random = new Random();
        int choice = random.Next(0,3);
        
        switch (choice)
        {
            case 0:
                output = "attack";
                break;
            case 1:
                output = "special";
                break;
            case 2:
                output = "dodge";
                break;
        }

        return output;
    }
}