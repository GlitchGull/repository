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
        int damage2 = 4;
        int defense2 = 2;
        float critChance2 = 0.1f;
        string name2 = "Clanker";

        bool crit = IsCriticalHit(critChance1);
        int damage = calculateDamage1(damage1, defense2);
        PrintRound(name1, name2, damage, crit, health2);

    }
    
    static int calculateDamage1(int damage1, int defense2)
    {
        int attack1 = damage1 - (defense2 / 2);
        if (attack1 < 1) attack1 = 1;
        return attack1;
    }

    static bool IsCriticalHit(float critChance)
    {
        Random rng = new Random();
        float roll = (float)rng.NextDouble();
        return roll < critChance;
    }
    
    static void PrintRound(string name1, string name2, int damage1, bool crit, int health2)
        {
            Console.WriteLine($"{name1} attacks {name2}");
            if (crit)
                Console.WriteLine($"Damage: {damage1} (CRITICAL HIT):");
            else
                Console.WriteLine($"Damage: {damage1}");
            health2 -= damage1;
            Console.WriteLine($"{name2} has {health2} HP left.");
        }
}
