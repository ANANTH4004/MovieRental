using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using Flicks.Models;

namespace Flicks.Controllers
{
    public class MovieController : ApiController
    {
        // GET api/<controller>
        Operations op = null;
        public MovieController()
        {
            op = new Operations();
        }
        public List<Mv> Get()
        {
            var ans = op.GetMovies();
            List<Mv> deptlist = new List<Mv>();
            foreach (var item in ans)
            {
                deptlist.Add(new Mv() { Name = item.Name , Availability = item.Availability , Genre = item.Genre,Language=item.Language ,Rating = item.Rating , MovieID = item.MovieID });
            }
            return deptlist;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] Mv value)
        {
            Movie movie = new Movie();
            movie.MovieID = value.MovieID;
            movie.Rating = value.Rating;
            movie.Availability = value.Availability;
            movie.Genre = value.Genre;
            movie.Language = value.Language;
            movie.Name = value.Name;
            op.AddMovie(movie);
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