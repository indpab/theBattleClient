using System; 
using System.Collections.Generic;
using System.Configuration.Internal;
using System.Text;
using TheBattleShipClient.Models.Ships.Factories;

namespace TheBattleShipClient.Models.Ships.Builder
{
    public abstract class Builder
    {
        protected AbstractShipFactory _abstractShipFactory;
        protected List<ShipGroup> _shipGroups = new List<ShipGroup>();

        public abstract void AddSubmarineGroup(int count);
        public abstract void AddDestroyerGroup(int count);

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
