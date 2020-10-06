using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Services;

namespace TheBattleShipClient.Models.Ships
{
    public class AtomicDestroyer : Destroyer
    {
        public AtomicDestroyer(string token, string roomId, int x, int y, bool horizontal)
            : base(token, roomId, x, y, horizontal, 4)
        {
        }

        public override async Task Create()
        {
            var request = new Services.ShipsService.ShipRequest
            {
                X = this.X,
                XOffset = this.XOffset,
                Y = this.Y,
                YOffset = this.YOffset,
                ShipTypeId = 4
            };
            var ship = await ShipsService.CreateShip(_token, _roomId, request);
            this.Id = ship.Id;
            this.HP = ship.HP;
        }
    }
}
