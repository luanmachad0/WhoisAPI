using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class WhoisContext : DbContext
    {
        public WhoisContext()
            : base("WhoisContext")
        {
        }

        public DbSet<WhoisParsed> WhoisParseds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<WhoisContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}