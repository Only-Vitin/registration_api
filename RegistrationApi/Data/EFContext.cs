using Microsoft.EntityFrameworkCore;

using RegistrationApi.Entities;

namespace RegistrationApi.Data
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> opt) : base(opt){}

        public DbSet<User> User { get; set; }
        public DbSet<Token> Token { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Token>().ToTable("Token");

            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<Token>().HasKey(t => t.Id);

            modelBuilder.Entity<Token>()
                .HasOne(t => t.User)
                .WithMany(u => u.Tokens)
                .HasForeignKey(t => t.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
