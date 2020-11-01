using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Factories;

namespace TheBattleShipClient.Models.Ships.Builder
{
    class LargeShipGroupBuilder : Builder
    {
        public LargeShipGroupBuilder(string token, string roomId)
        {
            _abstractShipFactory = new LargeShipFactory(token, roomId);
        }

        public override void AddSubmarineGroup(int count)
        {
            var ships = new List<Ship>();
            for (int i = 0; i < count; i++)
            {
                ships.Add(_abstractShipFactory.CreateSubmarine(0, 0, true));
            }
            var shipGroup = new ShipGroup
            {
                Limit = count,
                Count = count,
                ShipType = new ShipType
                {
                    Name = "Large Submarine",
                    IsSubmarine = true,
                    Size = 3
                },
                Ships = ships
            };
            _shipGroups.Add(shipGroup);
        }

        public override void AddDestroyerGroup(int count)
        {
            var ships = new List<Ship>();
            for (int i = 0; i < count; i++)
            {
                ships.Add(_abstractShipFactory.CreateDestroyer(0, 0, true));
            }
            var shipGroup = new ShipGroup
            {
                Limit = count,
                Count = count,
                ShipType = new ShipType
                {
                    Name = "Large Destroyer",
                    IsSubmarine = false,
                    Size = 3
                },
                Ships = ships
            };
            _shipGroups.Add(shipGroup);
        }
    }
}
