using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace YumBlazor.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        public DbSet<Category>? Category { get; set; }

        public DbSet<UserInfo>? UserInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(

                new Category { Id = 1, Name = "Appetizer" },
                new Category { Id = 2, Name = "Entree" },
                new Category { Id = 3, Name = "Dessert" }
                );

            builder.Entity<UserInfo>().HasData(

                new UserInfo { Id = 1, FirstName = "Andrian", LastName = "Gultiano", Email = "andriangultiano14@gmail.com", Phone = "09670683081" },
                new UserInfo { Id = 2, FirstName = "Azmen", LastName = "Tamano", Email = "azmentamanogmail.com", Phone = "09670683081" },
                new UserInfo { Id = 3, FirstName = "Andrian", LastName = "Gultiano", Email = "andriangultiano14@gmail.com", Phone = "09670683081" }

                );
        }




    }
}
