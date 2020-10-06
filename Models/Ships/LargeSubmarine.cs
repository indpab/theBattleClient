using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Services;

namespace TheBattleShipClient.Models.Ships
{
    public class LargeSubmarine : Submarine
    {
        public LargeSubmarine(string token, string roomId, int x, int y, bool horizontal)
            : base(token, roomId, x, y, horizontal, 3)
        {
        }

        public override async void Create()
        {
            var request = new Services.ShipsService.ShipRequest
            {
                X = this.X,
                XOffset = this.XOffset,
                Y = this.Y,
                YOffset = this.YOffset,
                ShipTypeId = 7
            };
            var ship = await ShipsService.CreateShip(_token, _roomId, request);
            this.Id = ship.Id;
            this.HP = ship.HP;
        }
    }
}
