using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Services;

namespace TheBattleShipClient.Models.Ships
{
    [Serializable]
    public class AtomicDestroyer : Destroyer
    {
        public AtomicDestroyer(string token, string roomId, int x, int y, bool horizontal)
            : base(token, roomId, x, y, horizontal, 4)
        {
        }

        public override async Task Create()
        {
            var ship = await Service.CreateShip(_token, _roomId, X, XOffset, Y, YOffset, 4);
            this.Id = ship.Id;
            this.HP = ship.HP;
        }


    }
}
