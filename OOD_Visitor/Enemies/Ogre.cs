using System;
using Defenders;

namespace Enemies
{
    class Ogre : Enemy
    {
        public int Armor { get;  }

        public Ogre(string name, int hp, int armor) : base(name, hp)
        {
            Armor = armor;
        }

        
        public override void attack(IDefender DefenderVisitor)
        {
            int damage;
            damage=DefenderVisitor.Defend(this);
            
            GetDamage(Math.Max(1,(damage-Armor)));
            
        }

       

    }
}