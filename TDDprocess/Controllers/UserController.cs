using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace TDDprocess.Controllers
{
    public class UserController : ApiController
    {
        


        [HttpGet]
        public List<string> getUser()
        {

            var users = new List<string>();

            users.Add("Brian");
            users.Add("John");
            users.Add("Rin");
            users.Add("Shaw");

            return users.ToList();

        }


        
    }
}
