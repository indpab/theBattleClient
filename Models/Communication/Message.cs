using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Communication
{
    public class Message
    {
        public int Id { get; set; }
        public string RoomId { get; set; }
        public string UserId { get; set; }
        public string MessageContent { get; set; }
    }
}
