using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Algorithms;

namespace TheBattleShipClient.Models.Ships.Command
{
    public class TurnAroundShipCommand : ShipCommand
    {
        public TurnAroundShipCommand(Ship ship)
            :base(ship)
        {
        }

        public override async void execute()
        {
            var motionState = MotionStateFlyweightFactory.Instance.GetMotionState("turnAround");
            _ship.SetMotionState(motionState);
            await _ship.Move();
        }
    }
}
