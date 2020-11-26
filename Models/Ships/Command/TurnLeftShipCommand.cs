using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Algorithms;

namespace TheBattleShipClient.Models.Ships.Command
{
    public class TurnLeftShipCommand : ShipCommand
    {
        public TurnLeftShipCommand(Ship ship)
            :base(ship)
        {
        }

        public override async void execute()
        {
            var motionState = MotionStateFlyweightFactory.Instance.GetMotionState("turnLeft");
            _ship.SetMotionState(motionState);
            await _ship.Move();
        }
    }
}
