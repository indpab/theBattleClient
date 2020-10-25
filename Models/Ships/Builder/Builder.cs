using System; 
using System.Collections.Generic;
using System.Configuration.Internal;
using System.Text;
using TheBattleShipClient.Models.Ships.Factories;

namespace TheBattleShipClient.Models.Ships.Builder
{
    public abstract class Builder
    {
        protected string _token;
        protected string _roomId;
        protected AbstractShipFactory abstractShipFactory;
        protected ShipGroup shipGroup;
        public void SetFactory(AbstractShipFactory abstractShipFactory)
        {
            this.abstractShipFactory = abstractShipFactory;
        }
        public void InitializeShipGroup()
        {
            shipGroup = new ShipGroup();
        }
        public void SetShiptype(ShipType shipType)
        {
            shipGroup.ShipType = shipType;
        }
        public void SetLimit(int limit)
        {
            shipGroup.Limit = limit;
        }
        public void SetCount(int count)
        {
            shipGroup.Count = count;
        }
        public ShipGroup Build()
        {
            return shipGroup;
        }
    }
}
