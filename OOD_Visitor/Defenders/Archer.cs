using System;
using Enemies;

namespace Defenders
{
    class Archer : Warrior
    {
        private int arrows;

        public Archer(string name, int strength, int arrows) : base(name, strength)
        {
            this.arrows = arrows;
        }

        public override int Defend(Giant giant)
        {
            arrows -= 2;
            int damage = 0;
            damage += 2 * strength;
            Console.WriteLine($"{nameof(Archer)} {name} shoots 2 arrows to Giant {giant.Name}, Damage:-{damage}\n");
            return damage;
        }

        public override int Defend(Ogre ogre)
        {
            arrows -= 1;
            int damage = 0;
            damage += strength;
            Console.WriteLine($"{nameof(Archer)} {name} shoots 1 arrow to Ogre {ogre.Name}, Damage:-{damage}\n");
            return damage;
        }

        public override int Defend(Rat rat)
        {
            arrows -= 1;
            int damage = 0;
            damage += strength;
            Console.WriteLine($"{nameof(Archer)} {name} shoots 1 arrow to Rat {rat.Name}, Damage:-{damage}\n");
            return damage;
        }



    }
}