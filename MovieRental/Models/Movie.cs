using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public string Language { get; set; }
        public string Genre { get; set; }
        public int Availability { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}