using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Visitor;

namespace TheBattleShipClient.Models.Ships.Factories
{
    public class MediumShipFactory : AbstractShipFactory
    {
        public MediumShipFactory(string token, string roomId)
            : base(token, roomId)
        {
            destroyer_instance = new MediumDestroyer(token, roomId, 0, 0, false);
            submarine_instance = new MediumSubmarine(token, roomId, 0, 0, false);
        }

        public override Submarine CreateSubmarine(int x, int y, bool horizontal)
        {
            MediumSubmarine new_submarine = (MediumSubmarine)submarine_instance.DeepClone();
            new_submarine.X = x;
            new_submarine.Y = y;
            new_submarine.Rotate(horizontal);
            VisitorMedium visitorMedium = new VisitorMedium();
            new_submarine.Accept(visitorMedium);
            return new_submarine;
        }

        public override Destroyer CreateDestroyer(int x, int y, bool horizontal)
        {
            MediumDestroyer new_destroyer = (MediumDestroyer)destroyer_instance.DeepClone();
            new_destroyer.X = x;
            new_destroyer.Y = y;
            new_destroyer.Rotate(horizontal);
            VisitorMedium visitorMedium = new VisitorMedium();
            new_destroyer.Accept(visitorMedium);
            return new_destroyer;
        }
    }
}
