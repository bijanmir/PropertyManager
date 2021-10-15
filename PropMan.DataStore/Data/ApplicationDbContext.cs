using Microsoft.EntityFrameworkCore;
using PropertyManager.DataModel.Model;

namespace PropMan.DataStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Property> Properties { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
    }
}