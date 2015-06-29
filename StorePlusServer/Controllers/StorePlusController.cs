﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using StorePlusServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace StorePlusServer.Controllers
{

    
    [RoutePrefix("api/items")]
    public class StorePlusController : ApiController
    {
        [Route("{itemId}")]
        public HttpResponseMessage Get(String itemId)
        {
            SingleItem singleItem = null;
            if (itemId == "0688740980202") {
                singleItem = new SingleItem("0688740980202", "Micro-patterned oxford shirt", 25.99, "http://static.zara.net/photos//2015/V/0/2/p/4036/260/403/2/w/1024/4036260403_1_1_1.jpg");
                singleItem.sizes.Add(new SingleItem.ItemSize("s", "S", inbagsStock: "0", availbleStock: "4"));
                singleItem.sizes.Add(new SingleItem.ItemSize("m", "M", inbagsStock: "1", availbleStock: "2"));
                singleItem.sizes.Add(new SingleItem.ItemSize("l", "L", inbagsStock: "2", availbleStock: "5"));
            }
            else if (itemId == "0503911180002")
            {
                singleItem = new SingleItem("0503911180002", "Faux leather bomber jacket", 39.99, "http://static.zara.net/photos//2015/V/0/2/p/0706/405/700/2/w/1024/0706405700_1_1_1.jpg");
                singleItem.sizes.Add(new SingleItem.ItemSize("s", "S", inbagsStock: "4", availbleStock: "2"));
                singleItem.sizes.Add(new SingleItem.ItemSize("m", "M", inbagsStock: "1", availbleStock: "7"));
                singleItem.sizes.Add(new SingleItem.ItemSize("l", "L", inbagsStock: "0", availbleStock: "5"));
            }

            var httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK, singleItem, JsonMediaTypeFormatter.DefaultMediaType);

            var objectContent = httpResponseMessage.Content as ObjectContent;
            if (objectContent != null)
            {
                var jsonMediaTypeFormatter = new JsonMediaTypeFormatter
                {
                    SerializerSettings =
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    }
                };
                httpResponseMessage.Content = new ObjectContent(objectContent.ObjectType, objectContent.Value, jsonMediaTypeFormatter);
            }

            return httpResponseMessage;
        }
    }
}
