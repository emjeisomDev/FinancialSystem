using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configuration
{
    public class BaseContext : IdentityDbContext<ApplicationUser>
    {
        public BaseContext(DbContextOptions options) : base(options){}

        public DbSet<FinancialSystem> FinancialSystem { get; set; }
        public DbSet<UserFinancialSystem> UserFinancialSystem { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Expense> Expense { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
                base.OnConfiguring(optionsBuilder);
            }
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);
            base.OnModelCreating(builder);  
        }

        private string GetConnectionString() 
            => @"Server=DESKTOP-MN8G6NB\\SQLEXPRESS,1433;
                Database=FiancialSystem2023;
                User Id=sa;
                Password=1q2w3e4r@#$;
                Encrypt=false;
                TrustServerCertificate=True;
                MultiSubnetFailover=True;";


    }
}
