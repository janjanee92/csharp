using System;

namespace CSharp
{
    // Ref
    class Knight
    {
        public int hp;
        public int attack;
        public Knight Clone()
        {
            Knight clone = new Knight();
            clone.hp = hp;
            clone.attack = attack;
            return clone;
        }

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }

    // Copy
    struct Mage
    {
        public int hp;
        public int attack;
    }

    class Program 
    {
        static void KillMage(ref Mage mage)
        {
            mage.hp = 0;
        }

        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }

        static void Main(string[] args)
        {
            Mage mage = new Mage();
            mage.hp = 100;
            mage.attack = 50;

            Mage mage2 = mage;
            mage2.hp = 0;

            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;

            Knight knight2 = knight.Clone();
            knight.hp = 0;
        }
    }
}
