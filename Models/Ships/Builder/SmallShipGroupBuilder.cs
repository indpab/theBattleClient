using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships;
using TheBattleShipClient.Models.Ships.Builder;
using TheBattleShipClient.Models.Ships.Factories;

namespace TheBattleShipClient.Models
{
    public class SmallShipGroupBuilder : Builder
    {
        public SmallShipGroupBuilder(string token, string roomId)
        {
            _abstractShipFactory = new SmallShipFactory(token, roomId);
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
                    Name = "Small Submarine",
                    IsSubmarine = true,
                    Size = 1
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
                    Name = "Small Destroyer",
                    IsSubmarine = false,
                    Size = 1
                },
                Ships = ships
            };
            _shipGroups.Add(shipGroup);
        }

    }
}
