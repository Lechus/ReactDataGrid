using Microsoft.EntityFrameworkCore;

namespace Company.Employees.Database
{
    public class OrganisationsDbContext : DbContext
    {
        public OrganisationsDbContext(DbContextOptions<OrganisationsDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Organisation> Organisations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee").HasKey(e => new { e.OrganisationNumber, e.FirstName, e.LastName});    
            modelBuilder.Entity<Organisation>().ToTable("Organisation");
        }
    }
}
