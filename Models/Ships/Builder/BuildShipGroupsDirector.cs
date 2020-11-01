using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Builder
{
    public class BuildShipGroupsDirector
    {
        private Builder _builder;

        public BuildShipGroupsDirector(Builder builder)
        {
            _builder = builder;
        }

        public void Construct(int destroyersCount = 0, int submarinesCount = 0)
        {
            _builder.AddDestroyerGroup(destroyersCount);
            _builder.AddSubmarineGroup(submarinesCount);
        }
    }
}
