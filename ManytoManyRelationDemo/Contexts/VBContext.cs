using Microsoft.EntityFrameworkCore;

public class VBContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"data source=(localdb)\mssqllocaldb;database=CardbSam;trusted_connection=true");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Teacher>()
        //    .HasMany(t => t.Students)
        //    .WithMany(t => t.Teachers)
        //    .UsingEntity<School>();
    }
    public DbSet<Course> School { get; set; }
   // public DbSet<Teacher> Teacher { get; set; }
    public DbSet<Student> Student { get; set; }
}
//public class School
//{
//    public int SchoolId { get; set; }
//    public List<Teacher> Teachers { get; set; }
//    public List<Student> Students { get; set; }
//}
public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public List<Student> Students { get; set; }
    //public List<Student> Students { get; set; }
    //public List<School> Schools { get; set; }
    //public int TeacherId { get; set; }
}
public class Student
{
    //public List<School> Schools { get; set; }
    //public List<Teacher> Teachers { get; set; }
    public int StudentId { get; set; }
    public List<Course> Courses { get; set; }
}