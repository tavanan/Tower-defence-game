using System;
using Enemies;

namespace Defenders
{
    class RatCatcher : IDefender
    {
        protected readonly string name;
        private bool hasRat;

        public RatCatcher(string name)
        {
            this.name = name;
            hasRat=false;
        }

        public int Defend(Giant giant)
        {
            int damage = 0;
            if (hasRat)
            {
                Console.WriteLine($"{nameof(RatCatcher)} {name} has rat's body and ignore Giant {giant.Name} \n");
                return damage;
            }
            else
            {
                Console.WriteLine($"{nameof(RatCatcher)} {name} doesn't have rat's body and ignore Giant {giant.Name}\n");
                return damage;
            }
        }

        public int Defend(Ogre ogre)
        {
            int damage = 0;
            if(hasRat)
            {

                damage += 100000;
                hasRat = false;
                Console.WriteLine($"{nameof(RatCatcher)} {name} has rat's body and kills(run away) Ogre {ogre.Name} \n");
                return damage;

            }
            else
            {
                Console.WriteLine($"{nameof(RatCatcher)} {name} doesn't have rat's body and ignore Ogre {ogre.Name} \n");
                return damage;
            }
        }

        public int Defend(Rat rat)
        {
            int damage = 100000;
            hasRat = true;
            Console.WriteLine($"{nameof(RatCatcher)} {name} kills Rat {rat.Name} and take its body \n");
            return damage;

        }
    }
}