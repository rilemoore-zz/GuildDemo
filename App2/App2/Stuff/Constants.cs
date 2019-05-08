using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App2.Stuff
{
    public class Constants
    {
        public static string ActualBaseUrl = "http://ec2-18-216-89-31.us-east-2.compute.amazonaws.com:8080";
        public static string LoginUrl = "http://ec2-18-216-89-31.us-east-2.compute.amazonaws.com:8080/get/event";
        public static string BaseUrl = "http://ec2-18-216-89-31.us-east-2.compute.amazonaws.com:8080/new/event";
        public static string SearchUrl = "http://ec2-18-216-89-31.us-east-2.compute.amazonaws.com:8080/search/event";
        public static string CreateUserURL = "http://ec2-18-216-89-31.us-east-2.compute.amazonaws.com:8080/new/user";
        public static string CheckLoginURL = "http://ec2-18-216-89-31.us-east-2.compute.amazonaws.com:8080/confirm/user";
        public static string ConfirmUserURL = "http://ec2-18-216-89-31.us-east-2.compute.amazonaws.com:8080/get/user";
        public static List<BracketNames> Entrants = new List<BracketNames>();
        public static List<GameEvent> events = new List<GameEvent>();
        public static List<GameEvent> RegisteredEvents = new List<GameEvent>();
        public static List<GameEvent> SearchedEvents = new List<GameEvent>();
        public static List<GameEvent> CreatedEvents = new List<GameEvent>();
        public static List<GameEvent> InviteEvents = new List<GameEvent>();
        public static UserClass CurrentUser = new UserClass();
        public static bool RegEvents = false;
        public static bool SearchEvents = false;
        public static bool MyEvents = false;
    }
}
