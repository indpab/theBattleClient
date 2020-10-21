using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships;
using TheBattleShipClient.Models.Ships.Builder;
using TheBattleShipClient.Models.Ships.Factories;

namespace TheBattleShipClient.Models
{
    public class SmallShipGroupBuilder : IBuilder
    {

        ShipGroup shipGroup;
        /// <summary>
        /// Expects to get ShipGroup object with limitations initialized
        /// </summary>
        /// <param name="shipGroup">object, containing limitations</param>
        public void InitializeShipGroup(ShipGroup shipGroup)
        {
            this.shipGroup = shipGroup;
        }

        public void SetLimitations(int count, int limit)
        {
            shipGroup.Count = count;
            shipGroup.Limit = limit;
        }

        public void SetShipType(ShipType shipType)
        {
            shipGroup.ShipType = shipType;
        }

        public void AddSmallsubmarine(SmallShipFactory smallShipFactory)
        {
            SmallSubmarine smallSubmarine = smallShipFactory.CreateSubmarine(0, 0, false);
            shipGroup.Ships.Add(smallSubmarine);
        }

        public ShipGroup Build()
        {
            return shipGroup;
        }



    }
}
