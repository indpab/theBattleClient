using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Algorithms
{
    public class MoveStrategyFactoryFlyweight
    {
        public readonly Dictionary<string, IMotionAlgorithm> moveStrategyFlyweights = new Dictionary<string, IMotionAlgorithm>();
        
        public IMotionAlgorithm GetMoveStrategy(string strategy)
        {
            if (moveStrategyFlyweights.ContainsKey(strategy))
            {
                return moveStrategyFlyweights[strategy];
            }
            else
            {
                IMotionAlgorithm motionStrategy = null;
                switch (strategy)
                {
                    case "turnAround":
                        motionStrategy = new TurnAroundAlgorithm();
                        break;
                    case "straightFast":
                        motionStrategy = new MoveStraightFastAlgorithm();
                        break;
                    case "straightSlow":
                        motionStrategy = new MoveStraightSlowAlgorithm();
                        break;
                }
                if(motionStrategy != null)
                {
                    moveStrategyFlyweights.Add(strategy, motionStrategy);
                }
                return motionStrategy;
            }
        }
    }
}
