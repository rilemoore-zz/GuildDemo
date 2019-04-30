using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Stuff
{
    public class GameEvent
    {
        public List<GameEvent> events;

        [JsonProperty("Title")]
        public string EventTitle;

        [JsonProperty("Notes")]
        public string Notes;

        [JsonProperty("User ID")]
        public int UserId;

        [JsonProperty("Event Game")]
        public string EventGame;

        [JsonProperty("Start Date")]
        public string StartDate;

        [JsonProperty("Start Time")]
        public string StartTime;

        [JsonProperty("Platform")]
        public string Platform;

        [JsonProperty("Number of Players")]
        public int numberOfPlayers;

        [JsonProperty("Public")]
        public int Public;

         [JsonProperty("Event ID")]
         public int eventId;
    }
}