using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Factories;
using TheBattleShipClient.Models.Ships.Template;

namespace TheBattleShipClient.Models.Ships.Builder
{
    public abstract class FleetTemplate : IFleetTemplate
    {
        protected AbstractShipFactory _smallShipFactory;
        protected AbstractShipFactory _mediumShipFactory;
        protected AbstractShipFactory _atomicShipFactory;
        protected AbstractShipFactory _largeShipFactory;

        protected List<ShipGroup> shipGroup = new List<ShipGroup>();

        public FleetTemplate(string token, string roomId)
        {
            _smallShipFactory = new SmallShipFactory(token, roomId);
            _mediumShipFactory = new MediumShipFactory(token, roomId);
            _largeShipFactory = new LargeShipFactory(token, roomId);
            _atomicShipFactory = new AtomicShipFactory(token, roomId);
        }

        public sealed override List<ShipGroup> CreateFleet(int smallCount, int mediumCount, int largeCount, int atomicCount)
        {
            shipGroup.Add(CreateSmallShips(smallCount));
            shipGroup.Add(CreateMediumShips(mediumCount));
            shipGroup.Add(CreateLargeShips(largeCount));
            shipGroup.Add(CreateAtomicShips(atomicCount));

            return shipGroup;
        }

        protected abstract ShipGroup CreateSmallShips(int count);
        protected abstract ShipGroup CreateMediumShips(int count);
        protected abstract ShipGroup CreateLargeShips(int count);
        protected abstract ShipGroup CreateAtomicShips(int count);
    }
}
