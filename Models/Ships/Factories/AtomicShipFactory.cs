    using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Factories
{
    public class AtomicShipFactory : AbstractShipFactory
    {
        public AtomicShipFactory(string token, string roomId)
            :base(token, roomId)
        {
            destroyer_instance = new AtomicDestroyer(token, roomId, 0,0,false);
            submarine_instance = new AtomicSubmarine(token, roomId, 0, 0, false);
        }

        public override Submarine CreateSubmarine(int x, int y, bool horizontal)
        {
            AtomicSubmarine new_submarine = (AtomicSubmarine)submarine_instance.DeepClone();
            new_submarine.X = x;
            new_submarine.Y = y;
            new_submarine.Rotate(horizontal);
            return new_submarine;
        }

        public override Destroyer CreateDestroyer(int x, int y, bool horizontal)
        {
            AtomicDestroyer new_destroyer = (AtomicDestroyer)destroyer_instance.DeepClone();
            new_destroyer.X = x;
            new_destroyer.Y = y;
            new_destroyer.Rotate(horizontal);
            return new_destroyer;
        }

    }
}
