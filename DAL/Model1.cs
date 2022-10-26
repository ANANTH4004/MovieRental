using System;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class Model1 : DbContext
    {
      
        public Model1() : base("name=Model1")
        {
             Database.SetInitializer(new Model1Initalizer());
            //Database.SetInitializer<Model1>(new CreateDatabaseIfNotExists<Model1>());
        }
         public virtual DbSet<Movie> Movies { get; set; }
         public virtual DbSet<User> Users { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}