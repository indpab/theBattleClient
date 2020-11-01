using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Factories;

namespace TheBattleShipClient.Models.Ships.Builder
{
    class AtomicShipGroupBuilder : Builder
    {
        public void AddAtomicSubmarine()
        {
            AtomicSubmarine atomicSubmarine = (AtomicSubmarine)abstractShipFactory.CreateSubmarine(0, 0, false);
            shipGroup.Ships.Add(atomicSubmarine);
        }

        public void AddAtomicDestroyer()
        {
            AtomicDestroyer atomicDestroyer = (AtomicDestroyer)abstractShipFactory.CreateDestroyer(0, 0, false);
            shipGroup.Ships.Add(atomicDestroyer);
        }
    }
}
