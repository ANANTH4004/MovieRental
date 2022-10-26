using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public string Language { get; set; }
        public string Genre { get; set; }
        public int Availability { get; set; }
        public virtual ICollection<User> Users { get; set; }   

    }
}