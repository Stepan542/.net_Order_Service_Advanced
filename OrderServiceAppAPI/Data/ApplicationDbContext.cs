using Microsoft.EntityFrameworkCore;
using OrderServiceAppAPI.Models;

namespace OrderServiceAppAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Order> Orders { get; set; }
    }
}