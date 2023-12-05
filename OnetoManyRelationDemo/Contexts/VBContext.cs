using Microsoft.EntityFrameworkCore;

public class VBContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"data source=(localdb)\mssqllocaldb;database=CardbSam;trusted_connection=true");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>()
             .HasOne(p => p.Blog)
             .WithMany(p => p.Posts)
             .HasForeignKey(p => p.BlogId).IsRequired();
    }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
}
public class Blog
{
    public int Id { get; set; }
    public List<Post> Posts { get; set; }
}

public class Post
{
    public int Id { get; set; }
    public int BlogId { get; set; }
    public Blog Blog { get; set; }
}