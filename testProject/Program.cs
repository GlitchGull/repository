using System;

public class Program
{
    public static void Main()
    {
        int health1 = 50;
        int attack1 = 20;
        int defense1 = 25;
        float speed1 = 6;
        string name1 = "GlitchGull";

        int power1 = calculatePower1(attack1, defense1);
        bool fast1 = isFast1(speed1);
        bool ready1 = canFight1(health1, attack1);

        PrintStats1(name1, power1, fast1, ready1);
        Console.WriteLine();

        {
            int health2 = 5;
            int attack2 = 10;
            int defense2 = 2;
            float speed2 = 1;
            string name2 = "Vanilla (the bum)";

            int power2 = calculatePower2(attack2, defense2);
            bool fast2 = isFast2(speed2);
            bool ready2 = canFight2(health2, attack2);

            PrintStats2(name2, power2, fast2, ready2);
            Console.WriteLine(); // prints a blank line


            CompareFighters(name1, power1, name2, power2);
        }
        static void CompareFighters(string name1, int power1, string name2, int power2)
        {
            if (power1 > power2) Console.WriteLine($"Winner: {name1}");
            if (power1 < power2) Console.WriteLine($"Winner: {name2}");
            if (power1 == power2) Console.WriteLine($"It's a draw");
        }

    }

    static int calculatePower1(int attack1, int defense1)
    {
        return (attack1 + defense1) * 2;
    }

    static bool isFast1(float speed1)
    {
        return speed1 > 5;
    }

    static bool canFight1(int health1, int attack1)
    {
        return health1 > 0 && attack1 > 0;
    }

    static void PrintStats1(string name1, int power1, bool isFast1, bool canFight1)
    {
        Console.WriteLine($"Name: {name1}");
        Console.WriteLine($"Power: {power1}");
        Console.WriteLine($"Fast: {isFast1}");
        Console.WriteLine($"Ready to fight: {canFight1}");

        if (power1 > 300)
            Console.WriteLine("Overpowered!");
        else
            Console.WriteLine("Balanced!");
    }
    static int calculatePower2(int attack2, int defense2)
    {
        return (attack2 + defense2) * 2;
    }

    static bool isFast2(float speed2)
    {
        return speed2 > 5;
    }

    static bool canFight2(int health2, int attack2)
    {
        return health2 > 0 && attack2 > 0;
    }

    static void PrintStats2(string name2, int power2, bool isFast2, bool canFight2)
    {
        Console.WriteLine($"Name: {name2}");
        Console.WriteLine($"Power: {power2}");
        Console.WriteLine($"Fast: {isFast2}");
        Console.WriteLine($"Ready to fight: {canFight2}");

        if (power2 > 300)
            Console.WriteLine("Overpowered!");
        else
            Console.WriteLine("Balanced!");
    }
}
