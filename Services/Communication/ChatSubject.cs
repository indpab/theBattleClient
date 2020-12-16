using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Communication;

namespace TheBattleShipClient.Services.Communication
{
    public class ChatSubject : AbstractGameSubject
    {
        public bool isStarted = false;
        private int _newMessagesState;
        public int NewMessagesState
        {
            get { return _newMessagesState; }
            set
            {
                _newMessagesState = value;
                NotifyObservers();
            }
        }



        public ChatSubject()
        {
            NewMessagesState = 0;
        }

        public async void StartObserving(string token, string roomId)
        {
            bool stateChanged = false;
            while (!isStarted)
            {
                List<Message> messages = await CommunicationService.GetAllMessagesByRoomId(token, roomId);
               
                if (messages.Count != NewMessagesState)
                {
                    stateChanged = true;
                    NewMessagesState = messages.Count;
                }
            }
        }

    }
}
