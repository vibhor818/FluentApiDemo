using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetoOneRelationDemo.Models
{
    public class VBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"data source=(localdb)\mssqllocaldb;database=CardbSam;trusted_connection=true");
            optionsBuilder.UseSqlite(@"Data source=vbperson.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Person>().HasOne(p => p.Passport)
            //    .WithOne(p => p.Person)
            //    .HasForeignKey<Passport>(p => p.PersonId);

            //modelBuilder.Entity<Passport>()
            //    .HasOne(p => p.Person)
            //    .WithOne(p => p.Passport)
            //    .HasForeignKey<Person>(p => p.PersonId);

            //modelBuilder.Entity<Person>()
            //    .HasOne(p => p.Passport)
            //    .WithOne(p => p.Person)
            //    .HasForeignKey<Passport>();

            modelBuilder.Entity<Person>()
                .HasOne(p => p.Passport)
                .WithOne(p => p.Person)
                .HasForeignKey<Passport>("PassportId");

        }
        public DbSet<Person> People { get; set; }
        public DbSet<Passport> Passports { get; set; }
    }
    //Parent
    public class Person
    {
        public int Id { get; set; }
        //public string Name { get; set; }
        public Passport Passport { get; set; }
    }
    //Dependent
    public class Passport
    {
        public int Id { get; set; }
        //public string PassportNumber { get; set; }
        //public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
