using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StorePlusServer.Models
{
    public class Bag
    {
        public List<SingleItem> items;
        public User user;

        public Bag(User user = null, List<SingleItem> items = null)
        {
            this.items = items != null ? items : new List<SingleItem>();
            this.user = user != null ? user : new User();
        }
    }
}