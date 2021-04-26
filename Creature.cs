using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public enum CreatureType
    {
        None,
        Player = 1,
        Monster = 2
    }
    class Creature
    {
        protected CreatureType ctype = CreatureType.None;

        protected int hp = 0;
        protected int attack = 0;

        protected Creature(CreatureType type)
        {
            ctype = type;
        }

        public void SetInfo(int hp, int attack)
        {

            this.hp = hp;
            this.attack = attack;
        }
        public int GetHp() { return hp; }
        public int GetAttack() { return attack; }
        public bool IsDead() { return hp <= 0; }
        public void OnDamaged(int damage)
        {
            hp -= damage;
            if (hp < 0)
                hp = 0;
        }

    }
}
