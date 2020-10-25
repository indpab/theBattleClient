﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Models.Ships.Algorithms;
using TheBattleShipClient.Services;

namespace TheBattleShipClient.Models.Ships
{
    public class LargeDestroyer : Destroyer
    {
        public LargeDestroyer(string token, string roomId, int x, int y, bool horizontal)
            : base(token, roomId, x, y, horizontal, 3)
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
                ShipTypeId = 3
            };
            var ship = await ShipsService.CreateShip(_token, _roomId, request);
            this.Id = ship.Id;
            this.HP = ship.HP;
        }


    }
}
