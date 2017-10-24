using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarParkService.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        public IEnumerable<User> Get()
        {
            using (CarparkingDatabaseEntities entities = new CarparkingDatabaseEntities())
            {
                return entities.Users.ToList();
            }
        }
    }
}
