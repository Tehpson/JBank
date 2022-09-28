using Microsoft.EntityFrameworkCore;

namespace JBank.Models
{
    public class BankDBContext : DbContext
    {
        public BankDBContext(DbContextOptions<BankDBContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Seed();
    }
}