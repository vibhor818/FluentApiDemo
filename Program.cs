using FluentApiDemo.MyContexts;
using System.ComponentModel.DataAnnotations;

class Program
{
    public static void Main(string[] args)
    {
        using(VBContext con=new VBContext())
        {
            con.Database.EnsureDeleted();
            con.Database.EnsureCreated();
            Console.WriteLine("Db Created....");
        }
    }
}

