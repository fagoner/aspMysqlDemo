using Microsoft.EntityFrameworkCore;

namespace aspMysql.Models
{
  public class AspMysqlContext : DbContext
  {
    public AspMysqlContext(DbContextOptions<AspMysqlContext> options)
          : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<TodoItem>(entity =>
      {
        entity.Property(e => e.Name).HasMaxLength(50).HasDefaultValue(string.Empty);
      });
    }

  }
}


