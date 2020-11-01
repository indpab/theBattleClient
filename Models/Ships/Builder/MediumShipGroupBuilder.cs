using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Factories;

namespace TheBattleShipClient.Models.Ships.Builder
{
    class MediumShipGroupBuilder : Builder
    {
        public MediumShipGroupBuilder(string token, string roomId)
        {
            _abstractShipFactory = new MediumShipFactory(token, roomId);
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
                    Name = "Medium Submarine",
                    IsSubmarine = true,
                    Size = 2
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
                    Name = "Medium Destroyer",
                    IsSubmarine = false,
                    Size = 2
                },
                Ships = ships
            };
            _shipGroups.Add(shipGroup);
        }
    }
}
