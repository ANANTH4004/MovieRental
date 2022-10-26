using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Operations
    {
        Model1 context = null;
        public Operations()
        {
            context = new Model1();
        }
        public List<Movie> GetMovies()
        {
            return context.Movies.ToList();
        }
         
        public void AddMovie(Movie movie)
        {
             context.Movies.Add(movie);
            context.SaveChanges();
        }

        public List<User> GetUsers()
        {
            return context.Users.ToList();
        }
        public void AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
