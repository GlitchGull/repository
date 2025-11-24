using System;

public class Program
{

    public static int turn = 1;

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
        public virtual void AttackTarget(Fighter target)
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

    public class Boss : Fighter
    {
        public Boss(string name, int health, int attack, int defense)
            : base(name, health, attack, defense)
        {
        }

        public override void AttackTarget(Fighter target)
        {
            int damage = (Attack * 2) - (target.Defense / 2);
            if (damage < 1) damage = 1;

            target.Health -= damage;
            if (target.Health < 0) target.Health = 0;

            Console.WriteLine($"{Name} (BOSS) smashes {target.Name} with a massive hammer for {damage} damage!");
            Console.WriteLine($"{target.Name} has {target.Health} hp left");

            if (target.Health == 0)
            {
                Console.WriteLine($"{target.Name} has been defeated");
            }
        }
    }
public class Enemy : Fighter
    {
        public Enemy(string name, int health, int attack, int defense)
            : base(name, health, attack, defense)
        {
        }

        public override void AttackTarget(Fighter target)
        {
                    for (int i = 1; i <= 2; i++) 
                    {
                Console.WriteLine($"{Name} does a double attack");
            int damage = (Attack / 2) - (target.Defense / 2);
            if (damage < 1) damage = 1;

            target.Health -= damage;
            if (target.Health < 0) target.Health = 0;

            Console.WriteLine($"{Name} smashes {target.Name} with a massive hammer for {damage} damage!");
            Console.WriteLine($"{target.Name} has {target.Health} hp left");

            if (target.Health == 0)
            {
                    Console.WriteLine($"{target.Name} has been defeated");
                    break;
            }   
        }
    }
}

    public static void Main()
    {
        Boss f1 = new Boss("Shay (Final Boss)", 5550, 10, 15);
        Fighter f2 = new Fighter("Joel", 50, 50, 1);
        Enemy f3 = new Enemy("Maid outfit wearing eli", 10, 10, 10);
        f1.PrintStats();
        f2.PrintStats();
        f3.PrintStats();

        while (f1.Health > 0 && f2.Health > 0)
        {

            Console.WriteLine($"Turn {turn}");

            f2.AttackTarget(f1);
            if (f1.Health <= 0) break;
            f1.AttackTarget(f2);
            if (f2.Health <= 0) break;

            turn++;
        }
    }
}