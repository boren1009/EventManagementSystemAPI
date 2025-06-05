using Microsoft.EntityFrameworkCore;
using EventManagementSystemAPI.Models;

namespace EventManagementSystemAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Event> Events { get; set; }
    }
}
