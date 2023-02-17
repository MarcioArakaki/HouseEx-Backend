using HouseEX.Persistence.Model;
using Microsoft.EntityFrameworkCore;

namespace HouseEX.Persistence;
public class HouseExContext : DbContext
{
    public HouseExContext(DbContextOptions<HouseExContext> options) : base (options)
    {
    }
    
    public DbSet<User> Users { get; set; } = null!;
}
