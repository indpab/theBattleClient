using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleShipClient.Models.Weapons.Factories
{
    public abstract class WeaponFactory
    {
        protected string _token { get; set; }
        protected string _roomId { get; set; }

        public WeaponFactory(string token, string roomId)
        {
            _token = token;
            _roomId = roomId;
        }

        public abstract Task<Weapon> CreateWeapon(int x, int y);
    }
}
