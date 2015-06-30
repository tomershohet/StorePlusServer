using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StorePlusServer.Models
{
    public class User
    {
        public String id;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public String name;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public String imageUrl;

        public User(String id = null, String name = null, String imageUrl = null)
        {
            this.id = id;
            this.name = name;
            this.imageUrl = imageUrl;
        }
    }
}