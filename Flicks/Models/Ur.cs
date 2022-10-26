using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flicks.Models
{
    public class Ur
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public int Categoty { get; set; }

        public virtual ICollection<Mv> Movies { get; set; }
    }
}