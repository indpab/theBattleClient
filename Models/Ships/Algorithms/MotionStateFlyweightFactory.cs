using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Algorithms
{
    public sealed class MotionStateFlyweightFactory
    {
        private static readonly MotionStateFlyweightFactory _instance = new MotionStateFlyweightFactory();

        private MotionStateFlyweightFactory() { }

        public static MotionStateFlyweightFactory Instance
        {
            get
            {
                return _instance;
            }
        }

        private readonly Dictionary<string, IMotionState> motionStateFlyweights = new Dictionary<string, IMotionState>();
        
        public IMotionState GetMotionState(string stateKey)
        {
            if (motionStateFlyweights.ContainsKey(stateKey))
            {
                return motionStateFlyweights[stateKey];
            }
            else
            {
                IMotionState motionState = null;
                switch (stateKey)
                {
                    case "turnAround":
                        motionState = new TurnAroundState();
                        break;
                    case "straightFast":
                        motionState = new MoveStraightFastState();
                        break;
                    case "straightSlow":
                        motionState = new MoveStraightSlowState();
                        break;
                    case "turnLeft":
                        motionState = new TurnLeftState();
                        break;
                    case "turnRight":
                        motionState = new TurnRightState();
                        break;
                    default:
                        motionState = new DoNothingState();
                        break;
                }
                
                motionStateFlyweights.Add(stateKey, motionState);
                
                return motionState;
            }
        }
    }
}
