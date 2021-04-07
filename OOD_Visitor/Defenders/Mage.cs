using System;
using Enemies;

namespace Defenders
{
    class Mage : IDefender
    {
        protected readonly string name;
        protected int mana;
        protected readonly int manaRegen;
        protected readonly int spellPower;

        public Mage(string name, int mana, int manaRegen, int spellPower)
        {
            this.name = name;
            this.mana = mana;
            this.manaRegen = manaRegen;
            this.spellPower = spellPower;
        }

        protected bool CanCastSpell()
        {
            if (mana >= spellPower)
            {
                mana -= spellPower;
                return true;
            }

            Console.WriteLine($"{nameof(Mage)} {name} is recharging mana");
            RechargeMana();
            return false;
        }

        private void RechargeMana()
        {
            mana += manaRegen;
        }

        protected virtual int Strategy(Enemy enemy)
        {
            int damage = 0;
            if (CanCastSpell())
            {
                damage += spellPower;
                Console.WriteLine($"{nameof(Mage)} {name} cast spell {enemy.GetType().Name} {enemy.Name}, Damage:-{damage} \n");
                return damage;
            }
            else
            {
                RechargeMana();
                Console.WriteLine($"{nameof(Mage)} {name} ignore {enemy.GetType().Name} {enemy.Name} and recharge energy, total mana:{mana}\n");
                return damage;
            }
        }
        public virtual int Defend(Giant giant)
        {
            
            return Strategy(giant);
        }

        public virtual int Defend(Ogre ogre)
        {
            return Strategy(ogre);
        }

        public virtual int Defend(Rat rat)
        {
            return Strategy(rat);
        }
    }
}