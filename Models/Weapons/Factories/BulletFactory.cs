using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Weapons.Factories
{
    public class BulletFactory : WeaponFactory
    {
        public override Weapon CreateWeapon()
        {
            return new Bullet();
        }
    }
}
