using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Stuff
{
    public class UserClass
    {

        [JsonProperty("Username")]
        public string UserName;

        [JsonProperty("Password")]
        public string UserPassword;

        [JsonProperty("Last Name")]
        public string LastName;

        [JsonProperty("First Name")]
        public string FirstName;

        [JsonProperty("Age")]
        public int Age;

        [JsonProperty("Email")]
        public string Email;

        [JsonProperty("PlayerBio")]
        public string Bio;

        [JsonProperty("User ID")]
        public int ID;

    }
}
