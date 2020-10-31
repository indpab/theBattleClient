using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Services;
using static TheBattleShipClient.Services.WeaponsService;

namespace TheBattleShipClient.Models.Weapons.Factories.Adapter
{
    class MineFactoryAdapter : WeaponFactory
    {
        private MineFactory _mineFactory;

        public MineFactoryAdapter(string token, string roomId)
           : base(token, roomId)
        {
            _mineFactory = new MineFactory();
        }
        public override async Task<Weapon> CreateWeapon(int x, int y)
        {
            var weaponRequest = _mineFactory.Create(x, y);
            var mine = await _mineFactory.Shot(weaponRequest, _token, _roomId);
            return mine;
        }
    }
}
