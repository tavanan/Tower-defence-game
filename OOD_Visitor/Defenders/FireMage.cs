using System;
using Enemies;

namespace Defenders
{
    class FireMage : Mage
    {
        private double killChance;
        protected static readonly Random rng = new Random(1597);

        public FireMage(string name, int mana, int manaRegen, int spellPower, double killChance) : base(name, mana, manaRegen, spellPower)
        {
            this.killChance = killChance;
        }

        protected override int Strategy(Enemy enemy)
        {
            int damage = 0;
            if (rng.NextDouble() < killChance)
            {
                Console.WriteLine($"{nameof(FireMage)} {name} cast spell and kill immediately {enemy.GetType().Name } {enemy.Name} \n");
                return damage += 100000;
            }
            else
            {
                
                if (CanCastSpell())
                {
                    damage += spellPower;
                    Console.WriteLine($"{nameof(FireMage)} {name} cast spell {enemy.GetType().Name} {enemy.Name}, Damage:-{damage}\n");
                    return damage;
                }
                else
                {
                    mana += manaRegen;
                    Console.WriteLine($"{nameof(FireMage)} {name} cant cast spell {enemy.GetType().Name} {enemy.Name} and rechargin energy, total mana:{mana}\n");
                    return damage;
                }
            }
        }

        public override int Defend(Giant giant)
        {
            return Strategy(giant);
        }

        public override int Defend(Ogre ogre)
        {
            return Strategy(ogre);
        }

        public override int Defend(Rat rat)
        {
            return Strategy(rat);
        }




    }
}