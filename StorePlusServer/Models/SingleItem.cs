using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StorePlusServer.Models
{
    public class SingleItem
    {
        public String id;
        public String title;
        public double price;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public String color;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public String currency;
        public String imageURL;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemSize> sizes;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? date;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public String location;

        public SingleItem(String id, String title, Double price, String imageURL, String currency = null, List<ItemSize> itemSizes = null, DateTime? date = null, String location = null)
        {
            this.id = id;
            this.currency = currency;
            this.title = title;
            this.price = price;
            this.imageURL = imageURL;
            this.sizes = itemSizes != null ? itemSizes : new List<ItemSize>();
            this.date = date;
            this.location = location;
        }

        public class ItemSize
        {
            public String name;
            public String title;

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public String status;

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public String inbagsStock;

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public String availbleStock;

            public ItemSize(String name, String title, String status = null, String inbagsStock = null, String availbleStock = null)
            {
                this.name = name;
                this.title = title;
                this.status = status;
                this.inbagsStock = inbagsStock;
                this.availbleStock = availbleStock;
            }
        }
    }
}