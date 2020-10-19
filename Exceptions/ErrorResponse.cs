using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace TheBattleShipClient.Exceptions


{

    public class ErrorResponse
    {
        public class Error
        {
            [JsonPropertyName("message")]
            public string Message { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("errors")]
            public List<Error> Errors { get; set; }
        }
    }
    //public class ErrorResponse
    //{
    //    [JsonPropertyName("errors")]
    //    public List<Error> Errors { get; set; }
    //}


    //public class Error
    //{
    //    [JsonPropertyName("message")]
    //    public string Message { get; set; }
    //}



}
