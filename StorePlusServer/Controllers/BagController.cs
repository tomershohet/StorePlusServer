using StorePlusServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StorePlusServer.Controllers
{
    [RoutePrefix("store/{storeId}/users/{userID}/inbag")]
    public class InBagController : ApiController
    {
        #region In Bag Actions

        // 5. getUserBag
        // GET: store/{storeId}/users/{userID}/inbag
        [Route("")]
        public Bag Get() {
            User user = new User("14932590", "Tomer Shohet", "https://fbcdn-profile-a.akamaihd.net/hprofile-ak-xtf1/v/t1.0-1/p160x160/10561763_10152659558942682_4962942110060764144_n.jpg?oh=fc3a189547e1d87d0e22ac1c13e975fb&oe=56217C4E&__gda__=1445122776_a533be467206cc4ec8cac28d84f98260");
            List<SingleItem> itemsList = new List<SingleItem>() { new SingleItem("2", "Micro-patterned oxford shirt", 25.99, "http://static.zara.net/photos//2015/V/0/2/p/4036/260/403/2/w/1024/4036260403_1_1_1.jpg", itemSizes: new List<SingleItem.ItemSize>() { new SingleItem.ItemSize("m", "M", "in-bag") }) };
            Bag ret = new Bag(user, itemsList);
            
            return ret;
        }

        // 3. cleanUserBag
        // DELETE: store/{storeId}/users/{userID}/inbag/
        // Delete Add an item from a bag, and if not exist - return an error
        [Route("")]
        public storePlusResponse Delete()
        {
            var ret = new storePlusResponse() { status = "success" };
            return ret;
        }

        #endregion

        #region Item Actions

        // GET: store/{storeId}/users/{userID}/inbag/123
        [Route("{itemId}")]
        public string Get(int itemId)
        {
            return "value";
        }

        // 2. addItemToBag
        // PUT: store/{storeId}/users/{userID}/inbag/{itemId}
        // Add an item to bag, and if already exist - raise it's number
        [Route("{itemId}")]
        public storePlusResponse Put(int itemId, [FromBody]SingleItem value)
        {
            var ret = new storePlusResponse() { status = "success" , itemsInBag = "2"};
            return ret;
        }

        // 4. removeItemFromBag
        // DELETE: store/{storeId}/users/{userID}/inbag/{itemID}
        // Delete Add an item from a bag, and if not exist - return an error
        [Route("{itemId}")]
        public storePlusResponse Delete(int itemId)
        {
            var ret = new storePlusResponse() { status = "success", itemsInBag = "2" };
            return ret;
        }

        #endregion
    }

    [RoutePrefix("store/{storeId}/users/{userID}/pastBag")]
    public class PastBagController : ApiController
    {
        #region Past Bag Actions

        // 5. getUserPastBag
        // GET: store/{storeId}/users/{userID}/pastBag
        [Route("")]
        public Bag Get()
        {
            User user = new User("14932590", "Tomer Shohet", "https://fbcdn-profile-a.akamaihd.net/hprofile-ak-xtf1/v/t1.0-1/p160x160/10561763_10152659558942682_4962942110060764144_n.jpg?oh=fc3a189547e1d87d0e22ac1c13e975fb&oe=56217C4E&__gda__=1445122776_a533be467206cc4ec8cac28d84f98260");
            List<SingleItem> itemsList = new List<SingleItem>() { new SingleItem("3", "Linen basic shorts", 179.99, "http://static.zara.net/photos//2015/V/0/2/p/7248/402/250/2/w/1024/7248402250_6_1_1.jpg?timestamp=1426762967717", itemSizes: new List<SingleItem.ItemSize>() { new SingleItem.ItemSize("m", "M", "Tried on") }) };
            Bag ret = new Bag(user, itemsList);

            return ret;
        }

        #endregion
    }
}
