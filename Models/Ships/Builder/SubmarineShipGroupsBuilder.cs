using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Factories;

namespace TheBattleShipClient.Models.Ships.Builder
{
    public class SubmarineShipGroupsBuilder : Builder
    {
        public SubmarineShipGroupsBuilder(string token, string roomId)
            : base(token, roomId)
        {
        }

        public override void AddAtomicShips(int count)
        {
            var ships = new List<Ship>();
            for (int i = 0; i < count; i++)
            {
                ships.Add(_atomicShipFactory.CreateSubmarine(0, 0, true));
            }
            var shipGroup = new ShipGroup
            {
                Limit = count,
                Count = count,
                ShipType = new ShipType
                {
                    Name = "Atomic Submarine",
                    IsSubmarine = true,
                    Size = 4
                },
                Ships = ships
            };
            _shipGroups.Add(shipGroup);
        }

        public override void AddLargeShips(int count)
        {
            var ships = new List<Ship>();
            for (int i = 0; i < count; i++)
            {
                ships.Add(_largeShipFactory.CreateSubmarine(0, 0, true));
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

        public override void AddMediumShips(int count)
        {
            var ships = new List<Ship>();
            for (int i = 0; i < count; i++)
            {
                ships.Add(_mediumShipFactory.CreateSubmarine(0, 0, true));
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

        public override void AddSmallShips(int count)
        {
            var ships = new List<Ship>();
            for (int i = 0; i < count; i++)
            {
                ships.Add(_smallShipFactory.CreateSubmarine(0, 0, true));
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
    }
}
