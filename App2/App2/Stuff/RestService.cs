﻿using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using App2.Stuff;

namespace App2
{
   public class RestService
    {
        HttpClient client;
        string grant_type = "password";

        public RestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded' "));
        }

        public async Task<Token> Login(User user)
        {
            var postData = new List<KeyValuePair<string, string>>();
            postData.Add(new KeyValuePair<string, string>("grant_type", grant_type));
            postData.Add(new KeyValuePair<string, string>("username", user.Username));
            postData.Add(new KeyValuePair<string, string>("password", user.Password));
            var content = new FormUrlEncodedContent(postData);
            var response = await PostResponseLogin<Token>(Constants.LoginUrl, content);
            DateTime dt = new DateTime();
            dt = DateTime.Today;
            response.expire_date = dt.AddSeconds(response.expire_in);
            return response;
        }

        public async Task<T> PostResponseLogin<T>(string weburl, FormUrlEncodedContent content) where T : class
        {
            var response = await client.PostAsync(weburl, content);
            var jsonResult = response.Content.ReadAsStringAsync().Result;
            var token = JsonConvert.DeserializeObject <T>(jsonResult);
            return token;
        }

        public async Task<T> PostResponse<T>(string weburl, string jsonstring) where T : class
        {
            //var Token = App.TokenDatabase.GetToken();
            string ContentType = "application/json";
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Token.access_token);
            var result = await client.PostAsync(weburl, new StringContent(jsonstring, Encoding.UTF8, ContentType));
            var JsonResult = result.Content.ReadAsStringAsync().Result;
            var contentResp = JsonConvert.DeserializeObject<T>(JsonResult);
            return contentResp;
        }


        public async Task<T> GetResponse<T>(string weburl) where T :  class
        {
            //var Token = App.TokenDatabase.GetToken();
            
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Token.access_token);
            var response = await client.GetAsync(weburl);
            var JsonResult = response.Content.ReadAsStringAsync().Result;
            var contentResp = JsonConvert.DeserializeObject<T>(JsonResult);
            return contentResp;
        }



    }
}