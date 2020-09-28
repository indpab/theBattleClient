using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Weapons.Factories
{
    public abstract class WeaponFactory
    {
        public abstract Weapon CreateWeapon();
    }
}
