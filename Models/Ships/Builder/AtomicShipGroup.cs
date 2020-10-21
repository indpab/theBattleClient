using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Factories;

namespace TheBattleShipClient.Models.Ships.Builder
{
    class AtomicShipGroup : IBuilder
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

        public void AddMediumSubmarine(AtomicShipFactory atomicShipFactory)
        {
            AtomicSubmarine atomicSubmarine = (AtomicSubmarine)atomicShipFactory.CreateSubmarine(0, 0, false);
            shipGroup.Ships.Add(atomicSubmarine);
        }

        public void AddSmallDestroyer(AtomicShipFactory atomicShipFactory)
        {
            AtomicDestroyer atomicDestroyer = (AtomicDestroyer)atomicShipFactory.CreateDestroyer(0, 0, false);
            shipGroup.Ships.Add(atomicDestroyer);
        }

        public ShipGroup Build()
        {
            return shipGroup;
        }
    }
}
