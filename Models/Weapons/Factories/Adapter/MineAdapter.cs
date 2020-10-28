using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Services;
using static TheBattleShipClient.Services.WeaponsService;

namespace TheBattleShipClient.Models.Weapons.Factories.Adapter
{
    class MineAdapter : WeaponFactory
    {
        public MineAdapter(string token, string roomId)
           : base(token, roomId)
        {
        }
        public override async Task<Weapon> CreateWeapon(int x, int y)
        {
            MineFactory adaptee = new MineFactory();
            var weaponRequest = adaptee.Create(x, y);
            var mine = await adaptee.Shot(weaponRequest, _token, _roomId);
            return mine;
        }
    }
}
