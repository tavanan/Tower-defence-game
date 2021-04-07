using Enemies;

namespace Defenders
{
    interface IDefender
    {
        
        int Defend(Giant giant);
        int Defend( Rat rat);

        int Defend(Ogre ogre);
    }
}