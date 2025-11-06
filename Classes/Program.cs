using System;

public class Program
{

    public class Fighter
    {
        public string Name;
        public int Health;
        public int Attack;
        public int Defense;

        public Fighter(string name, int health, int attack, int defense)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
        }

        public void PrintStats()
        {
            Console.WriteLine($"{Name} | HP: {Health}, ATK: {Attack}, DEF: {Defense}");
        }
        public void AttackTarget(Fighter target)
        {
            int damage = Attack - (target.Defense / 2);
            if (damage < 1) damage = 1;
            target.Health -= damage;
            if (target.Health <= 0) target.Health = 0;
            Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage");
            Console.WriteLine($"{target.Name} has {target.Health} hp left");

            if (target.Health == 0)
            {
                Console.WriteLine($"{target.Name} has been defeated");
            }

        }
    }


public static void Main()
{
    Fighter f1 = new Fighter("Shay (Final Boss)", 5550, 10, 15);
    Fighter f2 = new Fighter("Weak Femboy Joel", 50, 50, 1);
    f1.PrintStats();
    f2.PrintStats();

        Console.WriteLine("Turn 1"); //replace 1 later

        f1.AttackTarget(f2);

        if (f2.Health > 0)
        {
            f2.AttackTarget(f1);
        }


}

}