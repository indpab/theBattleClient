using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Visitor;

namespace TheBattleShipClient.Models.Ships.Factories
{
    public class LargeShipFactory : AbstractShipFactory
    {
        public LargeShipFactory(string token, string roomId)
            : base(token, roomId)
        {
            destroyer_instance = new LargeDestroyer(token, roomId, 0, 0, false);
            submarine_instance = new LargeSubmarine(token, roomId, 0, 0, false);
        }
        public override Submarine CreateSubmarine(int x, int y, bool horizontal)
        {
            LargeSubmarine new_submarine = (LargeSubmarine)submarine_instance.DeepClone();
            new_submarine.X = x;
            new_submarine.Y = y;
            new_submarine.Rotate(horizontal);
            VisitorLarge visitorLarge = new VisitorLarge();
            new_submarine.Accept(visitorLarge);
            return new_submarine;
        }

        public override Destroyer CreateDestroyer(int x, int y, bool horizontal)
        {
            LargeDestroyer new_destroyer = (LargeDestroyer)destroyer_instance.DeepClone();
            new_destroyer.X = x;
            new_destroyer.Y = y;
            new_destroyer.Rotate(horizontal);
            VisitorLarge visitorLarge= new VisitorLarge();
            new_destroyer.Accept(visitorLarge);
            return new_destroyer;
        }
    }
}
