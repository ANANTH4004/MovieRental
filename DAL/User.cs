using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL
{
    public class User
    {
        [Key]
        [EmailAddress]
        public string UserID { get; set; }
        public string Password { get; set; }
        public int Categoty { get; set; }

       public virtual ICollection<Movie> Movies { get; set; } 
    }
}