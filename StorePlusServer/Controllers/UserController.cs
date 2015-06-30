using StorePlusServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StorePlusServer.Controllers
{
    [RoutePrefix("users")]
    public class UserController : ApiController
    {
        // 6. getUserDetails
        // GET: users/{userId}
        [Route("{userId}")]
        public User Get(int userId)
        {
            User user = new User("14932590", "Tomer Shohet", "https://fbcdn-profile-a.akamaihd.net/hprofile-ak-xtf1/v/t1.0-1/p160x160/10561763_10152659558942682_4962942110060764144_n.jpg?oh=fc3a189547e1d87d0e22ac1c13e975fb&oe=56217C4E&__gda__=1445122776_a533be467206cc4ec8cac28d84f98260");
            return user;
        }

        [Route("")]
        public User Post()
        {
            return new User(Guid.NewGuid().ToString());
        }
    }


}
