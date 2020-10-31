using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Services;
using static TheBattleShipClient.Services.WeaponsService;

namespace TheBattleShipClient.Models.Weapons.Factories
{
    public class MineFactory : WeaponFactory
    {
        public MineFactory(string token, string roomId)
            : base(token, roomId)
        {
        }

        public override async Task<Weapon> CreateWeapon(int x, int y)
        {
            ShotResponse shot = await Service.ShootWeapon(_token, _roomId, x, y, 3);
            var mine = new Mine
            {
                Id = shot.WeaponId,
                X = shot.X,
                Y = shot.Y,
                IsSuccessful = shot.Successful,
                ShipTypes = shot.ShipTypes.ToList(),
                IsDetonated = shot.Successful
            };
             return mine;
        }
    }
}
