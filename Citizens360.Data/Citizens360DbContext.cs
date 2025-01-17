using Citizens360.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Citizens360.Data;

public class Citizens360DbContext : DbContext
{
    public required DbSet<Employee> Employees { get; init; }

    public Citizens360DbContext(DbContextOptions options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder mBuilder)
    {
        mBuilder.Entity<Employee>()
            .HasIndex(e => new { e.Username })
            .IsUnique();
    }
}