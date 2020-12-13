using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Visitor;

namespace TheBattleShipClient.Models.Ships.Factories
{
    public class SmallShipFactory : AbstractShipFactory
    {
        public SmallShipFactory(string token, string roomId)
            : base(token, roomId)
        {
            destroyer_instance = new SmallDestroyer(token, roomId, 0, 0, false);
            submarine_instance = new SmallSubmarine(token, roomId, 0, 0, false);
        }

        public override Submarine CreateSubmarine(int x, int y, bool horizontal)
        {
            SmallSubmarine new_submarine = (SmallSubmarine)submarine_instance.DeepClone();
            new_submarine.X = x;
            new_submarine.Y = y;
            new_submarine.Rotate(horizontal);
            VisitorSmall visitorSmall = new VisitorSmall();
            new_submarine.Accept(visitorSmall);
            return new_submarine;
        }

        public override Destroyer CreateDestroyer(int x, int y, bool horizontal)
        {
            SmallDestroyer new_destroyer = (SmallDestroyer)destroyer_instance.DeepClone();
            new_destroyer.X = x;
            new_destroyer.Y = y;
            new_destroyer.Rotate(horizontal);
            VisitorSmall visitorSmall = new VisitorSmall();
            new_destroyer.Accept(visitorSmall);
            return new_destroyer;
        }
    }
}
