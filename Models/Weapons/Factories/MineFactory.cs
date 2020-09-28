using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Weapons.Factories
{
    public class MineFactory : WeaponFactory
    {
        public override Weapon CreateWeapon()
        {
            return new Mine();
        }
    }
}
