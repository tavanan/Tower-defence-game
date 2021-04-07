using System;
using Enemies;

namespace Defenders
{
    class Warrior : IDefender
    {
        protected readonly string name;
        protected readonly int strength;
        protected static readonly Random rng = new Random(1597);

        public Warrior(string name, int strength)
        {
            this.name = name;
            this.strength = strength;
        }

       

        public virtual int Defend(Giant giant)
        {
            
            int damage=0;
            damage += strength;
            Console.WriteLine($"{nameof(Warrior)} {name} attacks Giant{giant.Name}, Damage:-{strength}\n");
            return damage;
            
        }

        public virtual int Defend(Ogre ogre)
        {
            int damage = 0;
            damage += strength;
            Console.WriteLine($"{nameof(Warrior)} {name} attacks Ogre {ogre.Name}, Damage:-{strength}\n");
            return damage;
        }

        public virtual int Defend(Rat rat)
        {
            int damage = 0;
            if (rng.NextDouble() < rat.Speed / 100)
            {
                Console.WriteLine($"{nameof(Warrior)} {name} miss Rat {rat.Name}, Damage:-{damage}\n");
                return damage;
            }
            else
            {
                damage += strength;
                Console.WriteLine($"{nameof(Warrior)} {name} attacks Rat {rat.Name}, Damage:-{damage}\n");
                return damage;
            }
        }
    }
}