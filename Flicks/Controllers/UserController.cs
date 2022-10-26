using DAL;
using Flicks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Flicks.Controllers
{
    public class UserController : ApiController
    {
        // GET api/<controller>
        Operations op = null;
        public UserController()
        {
            op = new Operations();
        }
        public List<Ur> Get()
        {
            var ans = op.GetUsers();
            List<Ur> deptlist = new List<Ur>();
            foreach (var item in ans)
            {
                deptlist.Add(new Ur() { UserID = item.UserID, Password = item.Password , Categoty = item.Categoty });
            }
            return deptlist;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] Ur value)
        {
            User user = new User();
            user.UserID = value.UserID;
            user.Password = value.Password;
            user.Categoty =  value.Categoty;
            op.AddUser(user);

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}