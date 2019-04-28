using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App2.Stuff
{
    public class Constants
    {
        public static string LoginUrl = "http://ec2-18-216-89-31.us-east-2.compute.amazonaws.com:8080/get/event";
        public static string BaseUrl = "http://ec2-18-216-89-31.us-east-2.compute.amazonaws.com:8080/new/event";
        public static List<BracketNames> Entrants = new List<BracketNames>();
        public static List<GameEvent> events = new List<GameEvent>();
    }
}
