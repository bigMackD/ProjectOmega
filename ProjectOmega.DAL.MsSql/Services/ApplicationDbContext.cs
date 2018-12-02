using Microsoft.EntityFrameworkCore;
using ProjectOmega.Data.Entities;

namespace ProjectOmega.DAL.MsSql.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
