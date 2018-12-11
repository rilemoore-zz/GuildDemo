using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
namespace App2
{
    class RestService
    {
        HttpClient client;
        public RestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }
    }
}
