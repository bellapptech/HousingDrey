using HousingDrey.Models;
using Microsoft.EntityFrameworkCore;

namespace HousingDrey.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Property> Properties { get; set; }
    }
}