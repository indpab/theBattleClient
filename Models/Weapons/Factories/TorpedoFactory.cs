using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Weapons.Factories
{
    public class TorpedoFactory : WeaponFactory
    {
        public override Weapon CreateWeapon()
        {
            return new Torpedo();
        }
    }
}
