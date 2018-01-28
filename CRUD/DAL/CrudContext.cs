using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD.DAL
{
    public class CrudContext : DbContext
    {
        public CrudContext() : base("name=CrudConnectionString")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}