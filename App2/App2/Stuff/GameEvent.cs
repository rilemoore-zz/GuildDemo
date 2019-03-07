using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Stuff
{
    public class GameEvent
    {
        public List<GameEvent> events;

        [JsonProperty("Event  Title")]
        public string EventTitle;

        [JsonProperty("End Time")]
        public int EndTime;

        [JsonProperty("Event Date")]
        public string EventDate;

        [JsonProperty("User ID")]
        public int UserId;

        [JsonProperty("Event Game")]
        public string EventGame;

        [JsonProperty("Start Time")]
        public int StartTime;

        [JsonProperty("Platform")]
        public string Platform;

        [JsonProperty("Number of Players")]
        public int numberOfPlayers;

       /* [JsonProperty("Event ID")]
        public string eventId;*/
    }
}