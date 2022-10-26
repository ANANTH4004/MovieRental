using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flicks.Models
{
    public class Mv
    {
        public int MovieID { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public string Language { get; set; }
        public string Genre { get; set; }
        public int Availability { get; set; }
        public virtual ICollection<Ur> Users { get; set; }
    }
}