using System; 
using System.Collections.Generic;
using System.Configuration.Internal;
using System.Text;
using TheBattleShipClient.Models.Ships.Factories;

namespace TheBattleShipClient.Models.Ships.Builder
{
    public abstract class Builder
    {
        protected AbstractShipFactory _smallShipFactory;
        protected AbstractShipFactory _mediumShipFactory;
        protected AbstractShipFactory _largeShipFactory;
        protected AbstractShipFactory _atomicShipFactory;

        protected List<ShipGroup> _shipGroups = new List<ShipGroup>();

        public Builder(string token, string roomId)
        {
            _smallShipFactory = new SmallShipFactory(token, roomId);
            _mediumShipFactory = new MediumShipFactory(token, roomId);
            _largeShipFactory = new LargeShipFactory(token, roomId);
            _atomicShipFactory = new AtomicShipFactory(token, roomId);
        }

        public abstract void AddSmallShips(int count);
        public abstract void AddMediumShips(int count);
        public abstract void AddLargeShips(int count);
        public abstract void AddAtomicShips(int count);

        public void Reset()
        {
            _shipGroups = new List<ShipGroup>();
        }

        public List<ShipGroup> Build()
        {
            return _shipGroups;
        }
    }
}
