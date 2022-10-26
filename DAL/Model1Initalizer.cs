using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Model1Initalizer : DropCreateDatabaseIfModelChanges<Model1>
    {
        protected override void Seed(Model1 context)
        {
            List<User> users = new List<User>();
            users.Add(new User() { Categoty = 1, UserID = "varun@gmail.com", Password = "varun" });
            users.Add(new User() { Categoty = 1, UserID = "anand@gmail.com", Password = "anand" });
            context.Users.AddRange(users);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
