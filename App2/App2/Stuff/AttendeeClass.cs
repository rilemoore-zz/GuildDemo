using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Stuff
{
    public class AttendeeClass
    {

        [JsonProperty("User ID")]
        public int UserID;

        [JsonProperty("Status")]
        public string Status;

        [JsonProperty("Event ID")]
        public int EventID;

        [JsonProperty("AttendeeListID")]
        public string AttendeeListID;

    }
}
