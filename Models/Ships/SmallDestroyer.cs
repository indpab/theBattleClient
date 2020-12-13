using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Models.Ships.Visitor;
using TheBattleShipClient.Services;

namespace TheBattleShipClient.Models.Ships
{
    [Serializable]
    public class SmallDestroyer : Destroyer
    {
        public SmallDestroyer(string token, string roomId, int x, int y, bool horizontal)
            : base(token, roomId, x, y, horizontal, 1)
        {
        }

        public override async Task Create()
        {
            int shipType = ShipTypeMappings.typeIdPairs.GetValueOrDefault(this.ShipType.Name);
            var ship = await Service.CreateShip(_token, _roomId, X, XOffset, Y, YOffset, shipType);
            this.Id = ship.Id;
            this.HP = ship.HP;
        }
    }
}
