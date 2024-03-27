using Microsoft.EntityFrameworkCore;
using Project3.Models;
namespace Project3.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {


        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Niki" },
                new Company { Id = 2, Name = "Adidas" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Tutorial" },
                new Category { Id = 2, Name = "News" },
                new Category { Id = 3, Name = "Business" },
                new Category { Id = 4, Name = "Fitness" },
                new Category { Id = 5, Name = "Sports" }
                );
        }
    } 
}
