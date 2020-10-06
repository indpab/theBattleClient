using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleShipClient.Models.Weapons.Factories
{
    public abstract class WeaponFactory
    {
        public string Token { get; set; }
        public string RoomId { get; set; }

        public WeaponFactory(string token, string roomId)
        {
            Token = token;
            RoomId = roomId;
        }

        public abstract Task<Weapon> CreateWeapon(int x, int y);
    }
}
