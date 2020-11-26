using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Factories;

namespace TheBattleShipClient.Models.Ships.Builder
{
    public class SubmarineFleetTemplate : FleetTemplate
    {
        public SubmarineFleetTemplate(string token, string roomId)
            : base(token, roomId)
        {
        }
        protected override ShipGroup CreateAtomicShips(int count)
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

            return shipGroup;
        }

        protected override ShipGroup CreateLargeShips(int count)
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
            return shipGroup;
        }

        protected override ShipGroup CreateMediumShips(int count)
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
            return shipGroup;
        }

        protected override ShipGroup CreateSmallShips(int count)
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
            return shipGroup;
        }
    }
}
