using Microsoft.EntityFrameworkCore;

using RegistrationApi.Entities;
using RegistrationApi.Entities.Users;
using RegistrationApi.Entities.Products;

namespace RegistrationApi.Data
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> opt) : base(opt){}

        public DbSet<User> User { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }

        public DbSet<Product> Product { get; set; }
        public DbSet<Cleaning> Cleaning { get; set; }
        public DbSet<Drink> Drink { get; set; }
        public DbSet<Food> Food { get; set; }

        public DbSet<Token> Token { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasBaseType<User>();
            modelBuilder.Entity<Employee>().HasBaseType<User>();

            modelBuilder.Entity<Cleaning>().HasBaseType<Product>();
            modelBuilder.Entity<Drink>().HasBaseType<Product>();
            modelBuilder.Entity<Food>().HasBaseType<Product>();

            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<Product>().HasKey(p => p.Id);

            modelBuilder.Entity<Token>().HasKey(t => t.Id);

            modelBuilder.Entity<Token>()
                .HasOne(t => t.User)
                .WithMany(u => u.Tokens)
                .HasForeignKey(t => t.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
} 
