using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;


namespace App2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serialization");
            EventClass party = new EventClass {Title = "Dungeons and Dragons"};
            string result = JsonConvert.SerializeObject(party);
            Console.WriteLine(result);

        }
    }
    public class EventClass
    {
        public string Title { get; set; }
        public string EndTime { get; set; }
        public string UserID { get; set; }
        public string EventGame { get; set; }
        public string Platform { get; set; }
        public string NumPlayers { get; set; }
        public string StartTime { get; set; }
        public string EventDate { get; set; }
        [JsonProperty("body")]
        public string Content { get; set; }
        public override string ToString()
        {
            return string.Format(
                "Post Id: {0}\nTitle: {1}\nEndTime: {2}", UserID, Title, Content);
        }
    }

}
