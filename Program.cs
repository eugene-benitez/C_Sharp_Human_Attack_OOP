using System;

namespace Human
{

    class Human
    {
        static void Main(string[] args)
        {
            Human andrew = new Human("Andrew", 1, 20, 15, 80);
            System.Console.WriteLine(andrew.Name);
            System.Console.WriteLine(andrew.Strength);
            System.Console.WriteLine(andrew.health);
            Human steven = new Human("Steven", 10, 10, 15, 100);
            System.Console.WriteLine(steven.Name);
            System.Console.WriteLine(steven.Strength);
            System.Console.WriteLine(steven.health);
            andrew.Attack(steven);
            System.Console.WriteLine(steven.health);
        }

        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        public int Health
        {
            get
            {
                return health;
            }
        }

        public Human(string value, int str, int intel, int dex, int hp)
        {
            {
                Name = value;
                Strength = str;
                Intelligence = intel;
                Dexterity = dex;
                health = hp;
            }
        }

        public int Attack(Human target)
        {
            int damage = 5 * Strength;
            target.health -= damage;
            return target.health;
        }
    }
}

