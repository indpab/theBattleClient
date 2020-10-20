using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Services.Communication
{
    class GameObserver : IGameObserver
    {
        public String ObserverName { get; set; }
        public GameObserver(String name)
        {
            ObserverName = name;
        }

        public void Update(GameSubject subject)
        {
            if(subject.SubjectState == false)
            {
                subject.SubjectState = true;
            }
        }
    }
}
