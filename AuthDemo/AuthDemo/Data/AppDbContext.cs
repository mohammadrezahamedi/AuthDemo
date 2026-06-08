using AuthDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthDemo.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // this tells EF Core to create a "Users" table in the database
    public DbSet<User> Users => Set<User>();
}