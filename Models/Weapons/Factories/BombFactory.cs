using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Services;
using static TheBattleShipClient.Services.WeaponsService;

namespace TheBattleShipClient.Models.Weapons.Factories
{
    public class BombFactory : WeaponFactory
    {
        public BombFactory(string token, string roomId)
            : base(token, roomId)
        {
        }

        
        
        public override async Task<Weapon> CreateWeapon(int x, int y)
        {
            var weaponRequest = new WeaponRequest
            {
                X = x,
                Y = y,
                WeaponTypeId = 1
            };
            ShotResponse shot = await WeaponsService.Shot(_token, _roomId, weaponRequest);
            var bomb = new Bomb
            {
                Id = shot.WeaponId,
                X = shot.X,
                Y = shot.Y,
                IsSuccessful = shot.Successful,
                ShipTypes = shot.ShipTypes.ToList()
            };
            return bomb;
        }
    }
}
