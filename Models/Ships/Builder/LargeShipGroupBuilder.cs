using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Factories;

namespace TheBattleShipClient.Models.Ships.Builder
{
    class LargeShipGroupBuilder : IBuilder
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

        public void AddMediumSubmarine(LargeShipFactory largeShipFactory)
        {
            LargeShipFactory mediumSubmarine = (LargeShipFactory)largeShipFactory.CreateSubmarine(0, 0, false);
            shipGroup.Ships.Add(mediumSubmarine);
        }

        public void AddSmallDestroyer(MediumShipFactory mediumShipFactory)
        {
            MediumDestroyer mediumDestroyer = (MediumDestroyer)mediumShipFactory.CreateDestroyer(0, 0, false);
            shipGroup.Ships.Add(mediumDestroyer);
        }

        public ShipGroup Build()
        {
            return shipGroup;
        }
    }
}
