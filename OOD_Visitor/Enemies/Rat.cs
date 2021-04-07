using System;
using Defenders;

namespace Enemies
{
    class Rat : Enemy
    {
        public int Speed { get; private set; }

        public Rat(string name, int hp, int speed) : base(name, hp)
        {
            Speed = speed;
        }

        public override void attack(IDefender DefenderVisitor)
        {
            int damage;
            damage=DefenderVisitor.Defend(this);
            if (damage != 0)
            {
                Speed++;
            }
            GetDamage(damage);
        }
    }
}