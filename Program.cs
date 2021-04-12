using System;

namespace CSharp
{

    class Player
    {
        static public int counter = 1;

        public int id;
        public int hp;
        public int attack;

        public Player()
        {
            Console.WriteLine("플레이어 생성자 호출!");
        }

        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine("플레이어 hp 생성자 호출");
        }
        public void Move()
        {
            Console.WriteLine("Player Move");
        }

        public void Attack()
        {
            Console.WriteLine("Player Attack");
        }

    }
    class Mage : Player
    {

    }

    class Archer : Player
    {
        
    }

    // Ref
    class Knight : Player
    {

        public Knight() : base(100)
        {
            base.attack = 20;
            Console.WriteLine("Knight 생성자 호출");
        }

        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            return knight;
        }

    }

    class Program 
    {
        static void Main(string[] args)
        {
            Knight k = Knight.CreateKnight();
            k.Move();
        }
    }
}
