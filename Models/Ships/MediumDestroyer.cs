using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Services;

namespace TheBattleShipClient.Models.Ships
{
    public class MediumDestroyer : Destroyer
    {
        public MediumDestroyer(string token, string roomId, int x, int y, bool horizontal)
            : base(token, roomId, x, y, horizontal, 2)
        {
        }

        public override async Task Create()
        {
            var ship = await Service.CreateShip(_token, _roomId, X, XOffset, Y, YOffset, 2);
            this.Id = ship.Id;
            this.HP = ship.HP;
        }
    }
}
