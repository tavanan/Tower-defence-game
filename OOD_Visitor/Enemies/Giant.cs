using System;
using Defenders;

namespace Enemies
{
    class Giant : Enemy
    {

        public Giant(string name, int hp) : base(name, hp)
        {
        }

        public override void attack(IDefender DefenderVisitor)
        {
            int damage;
            damage=DefenderVisitor.Defend(this);
            this.GetDamage(damage);
        }
    }
}