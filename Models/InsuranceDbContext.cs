using Microsoft.EntityFrameworkCore;

namespace InsuranceMVC.Models
{
    public class InsuranceDbContext : DbContext
    {
        public InsuranceDbContext(DbContextOptions<InsuranceDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Claim> Claims { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Policy> Policies { get; set; }
        public virtual DbSet<PremiumCalculation> PremiumCalculations { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
