using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using TheBattleShipClient.Models.Ships;
using TheBattleShipClient.Models.Ships.Builder;
using TheBattleShipClient.Models.Ships.Factories;

namespace TheBattleShipClient.Models
{
    public class DestroyerFleetTemplate : FleetTemplate
    {
        public DestroyerFleetTemplate(string token, string roomId)
            : base(token, roomId)
        {
        }

        protected override ShipGroup CreateAtomicShips(int count)
        {
            var ships = new List<Ship>();
            for (int i = 0; i < count; i++)
            {
                ships.Add(_atomicShipFactory.CreateDestroyer(0, 0, true));
            }
            var shipGroup = new ShipGroup
            {
                Limit = count,
                Count = count,
                ShipType = new ShipType
                {
                    Name = "Atomic Destroyer",
                    IsSubmarine = false,
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
                ships.Add(_largeShipFactory.CreateDestroyer(0, 0, true));
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
            return shipGroup;
        }

        protected override ShipGroup CreateMediumShips(int count)
        {
            var ships = new List<Ship>();
            for (int i = 0; i < count; i++)
            {
                ships.Add(_mediumShipFactory.CreateDestroyer(0, 0, true));
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
            return shipGroup;
        }

        protected override ShipGroup CreateSmallShips(int count)
        {
            var ships = new List<Ship>();
            for (int i = 0; i < count; i++)
            {
                ships.Add(_smallShipFactory.CreateDestroyer(0, 0, true));
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
            return shipGroup;
        }
    }
}
