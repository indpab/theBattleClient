using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Models.Ships.Visitor;
using TheBattleShipClient.Services;

namespace TheBattleShipClient.Models.Ships
{
    [Serializable]
    public class AtomicSubmarine : Submarine
    {
        public AtomicSubmarine(string token, string roomId, int x, int y, bool horizontal)
            : base(token, roomId, x, y, horizontal, 4)
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
