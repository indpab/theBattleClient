using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Builder
{
    class BuildShipGroupsDirector
    {
        private Builder _builder;

        public BuildShipGroupsDirector(Builder builder)
        {
            _builder = builder;
        }

        public void ConstructShipGroups(int smallShipsCount = 0,
                                        int mediumShipsCount = 0,
                                        int largeShipsCount = 0,
                                        int atomicShipsCount = 0)
        {
            _builder.AddSmallShips(smallShipsCount);
            _builder.AddMediumShips(mediumShipsCount);
            _builder.AddLargeShips(largeShipsCount);
            _builder.AddAtomicShips(atomicShipsCount);
        }
    }
}
