using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class User
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public int Categoty { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}