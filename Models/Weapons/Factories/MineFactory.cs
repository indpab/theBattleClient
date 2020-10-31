using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Services;
using static TheBattleShipClient.Services.WeaponsService;

namespace TheBattleShipClient.Models.Weapons.Factories
{
    public class MineFactory
    {   
        public WeaponRequest Create(int x, int y)
        {
            var weaponRequest = new WeaponRequest
            {
                X = x,
                Y = y,
                WeaponTypeId = 3
            };
            return weaponRequest;
        }

        public async Task<Weapon> Shot(WeaponRequest weaponRequest, string _token, string _roomId)
        {
            ShotResponse shot = await Service.ShootWeapon(_token, _roomId, weaponRequest.X, weaponRequest.Y, weaponRequest.WeaponTypeId);
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

