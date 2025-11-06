using System;

public class Program
{
    public static void Main()
    {
        int health1 = 100;
        int damage1 = 15;
        int defense1 = 8;
        float critChance1 = 0.3f;
        string name1 = "GlitchGull";

        int health2 = 50;
        int damage2 = 15;
        int defense2 = 2;
        float critChance2 = 0.9f;
        string name2 = "Clanker";
        bool isPlayerTurn = true;

        int round = 1;

        while (health1 > 0 && health2 > 0)
        {
            Console.WriteLine($"---Round {round} ---");
            if (isPlayerTurn)
            {
                int damageDealt1 = calculateDamage1(damage1, defense2);
                health2 -= damageDealt1;
                if (health2 < 0) health2 = 0;
                bool crit1 = IsCriticalHit(critChance1);
                PrintRound1(name1, name2, damageDealt1, crit1, health2);
                if (health2 <= 0)
                {
                    Console.WriteLine($"{name2} has been defeated");
                    break;
                }
            }
            else
            {
                int damageDealt2 = calculateDamage2(damage2, defense1);
                health1 -= damageDealt2;
                if (health1 < 0) health1 = 0;
                bool crit2 = IsCriticalHit(critChance2);
                PrintRound2(name1, name2, damageDealt2, crit2, health1);
                if (health1 <= 0)
                {
                    Console.WriteLine($"{name2} has been defeated");
                    break;
                }
            }
            isPlayerTurn = !isPlayerTurn;
            round++;
        }
    }

    static int calculateDamage1(int damage1, int defense2)
    {
        int attack1 = damage1 - (defense2 / 2);
        if (attack1 < 1) attack1 = 1;
        return attack1;
    }
    
    static int calculateDamage2(int damage2, int defense1)
    {
        int attack2 = damage2 - (defense1 / 2);
        if (attack2 < 1) attack2 = 1;
        return attack2;
    }

    static bool IsCriticalHit(float critChance)
    {
        Random rng = new Random();
        float roll = (float)rng.NextDouble();
        return roll < critChance;
    }

    static void PrintRound1(string name1, string name2, int damage1, bool crit1, int health2)
    {
        Console.WriteLine($"{name1} attacks {name2}");
        if (crit1)
            Console.WriteLine($"Damage: {damage1} (CRITICAL HIT):");
        else
            Console.WriteLine($"Damage: {damage1}");
        Console.WriteLine($"{name2} has {health2} HP left.");
    }
        static void PrintRound2(string name1, string name2, int damage2, bool crit2, int health1)
        {
            Console.WriteLine($"{name2} attacks {name1}");
            if (crit2)
                Console.WriteLine($"Damage: {damage2} (CRITICAL HIT):");
            else
                Console.WriteLine($"Damage: {damage2}");
            Console.WriteLine($"{name1} has {health1} HP left.");
        }
}
