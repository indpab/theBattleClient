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

            ShotResponse shot = await Service.ShootWeapon(_token, _roomId, x, y, 1);
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
