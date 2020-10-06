using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Exceptions
{
    [JsonArray]
    public class ErrorResponse
    {
        public List<ErrorModel> Errors { get; set; }
    }
}
