using Microsoft.EntityFrameworkCore;
using ShadowPropertyDemo;

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
            
            Console.WriteLine("DB Created.....");
        }
    }
}
