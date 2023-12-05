using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApiDemo.MyContexts
{
    public class VBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=(localdb)\mssqllocaldb;database=CardbSam;trusted_connection=true");
        }
  
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Car>().HasKey(c => c.LicensePlate).HasName("DbPK_Cars");
            //modelBuilder.Entity<Blog>().Property(c => c.Created).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Person>().
                Property(p => p.DisplayName).HasComputedColumnSql("[LastName] + ', ' +[FirstName]");
        }
        // public DbSet<Car> Cars { get; set; }
        //public DbSet<Blog> Blogs { get; set; }
        //public DbSet<Pers MyProperty { get; set; }
    }
  //  [PrimaryKey(nameof(Model),nameof(LicensePlate))]
    public class Car
    {
        //[Key]
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    public class Blog
    {
        public int Id { get; set; }
        public string BlogContent { get; set; }
        public DateTime Created { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }

    }
}
