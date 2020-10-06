using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Services;

namespace TheBattleShipClient.Models.Ships
{
    public class SmallDestroyer : Destroyer
    {
        public SmallDestroyer(int x, int y, bool horizontal) : base(x, y, horizontal, 1)
        {
        }

        public override async void Create(string token, string roomId)
        {
            var request = new Services.ShipsService.ShipRequest
            {
                X = this.X,
                XOffset = this.XOffset,
                Y = this.Y,
                YOffset = this.YOffset,
                ShipTypeId = 1
            };
            var ship = await ShipsService.CreateShip(token, roomId, request);
            this.Id = ship.Id;
            this.HP = ship.HP;
        }
    }
}
