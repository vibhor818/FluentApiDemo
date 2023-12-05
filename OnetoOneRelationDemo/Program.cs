
using OnetoOneRelationDemo.Models;

class Program
{
    public static void Main(string[] args)
    {
        using (VBContext con = new VBContext())
        {
            con.Database.EnsureDeleted();
            con.Database.EnsureCreated();
            //Blog blog = new Blog();
            //con.Entry(blog).Property("LastUpdated").CurrentValue = DateTime.Now;

            //con.Blogs.OrderBy(a => EF.Property<DateTime>(a, "LastUpdated"));

            //var passport = new Passport() { PassportNumber = "XYZ675ABX" };

            //var person=new Person() { Name = "John", Passport=passport };
            //con.People.Add(person);
            //con.SaveChanges();

            Console.WriteLine("Person and passport added in db.......");
        }
    }
}