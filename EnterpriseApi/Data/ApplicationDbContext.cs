using EnterpriseApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseApi.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {    
        }
        public DbSet<Enterprise> Enterprises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enterprise>().HasData(
           new Enterprise
           {
               Id = 1,
               Name = "Angular Blue Boot",
               Description = "unning as admin worked for me after experiencing the same issue.",
               Price = 19000,
               PictureUrl = "https://www.pexels.com/photo/white-concrete-2-storey-house-206172/",
               Brand = "DELL G5",
               Type = "Angular",
               QuantityInStock = 100,
               CreatedDate = DateTime.Now

           },
              new Enterprise
              {
                  Id = 2,
                  Name = "Angular Blue Boot",
                  Description = "unning as admin worked for me after experiencing the same issue.",
                  Price = 19000,
                  PictureUrl = "https://www.pexels.com/photo/white-concrete-2-storey-house-206172/",
                  Brand = "DELL G5",
                  Type = "Angular",
                  QuantityInStock = 100,
                  CreatedDate = DateTime.Now

              },
              new Enterprise
              {
                  Id = 3,
                  Name = "Core Red Boot",
                  Description = "Core I5 16gb RAM 256gb SSD 10th Generation 14inch Screen",
                  Price = 18999,
                  PictureUrl = "https://www.pexels.com/photo/palm-trees-at-night-258154/",
                  Brand = "Redis",
                  Type = "Boot",
                  QuantityInStock = 100,
                  CreatedDate = DateTime.Now
              },
              new Enterprise
              {
                  Id = 4,
                  Name = "Core Purple Boot",
                  Description = "Running as admin worked for me after experiencing the same issue.",
                  Price = 17990,
                  PictureUrl = "ihttps://www.pexels.com/photo/palm-trees-at-night-258154/",
                  Brand = "Net Core",
                  Type = "Boot",
                  QuantityInStock = 100,
                  CreatedDate = DateTime.Now
              },
            new Enterprise
            {
                Id = 5,
                Name = "Angular Blue Boot",
                Description = "Core I5 16gb RAM 256gb SSD 10th Generation 14inch Screen",
                Price = 430000,
                PictureUrl = "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/",
                Brand = "DELL G5",
                Type = "Angular",
                QuantityInStock = 100,
                CreatedDate = DateTime.Now
            },
             new Enterprise
             {
                 Id = 6,
                 Name = "Core Purple Boot",
                 Description = "Running as admin worked for me after experiencing the same issue.",
                 Price = 17990,
                 PictureUrl = "https://www.pexels.com/photo/palm-trees-at-night-258154/",
                 Brand = "Net Core",
                 Type = "Boot",
                 QuantityInStock = 100,
                 CreatedDate = DateTime.Now
             },
            new Enterprise
            {
                Id = 7,
                Name = "Angular Blue Boot",
                Description = "Core I5 16gb RAM 256gb SSD 10th Generation 14inch Screen",
                Price = 430000,
                PictureUrl = "https://www.pexels.com/photo/palm-trees-at-night-258154/",
                Brand = "DELL G5",
                Type = "Angular",
                QuantityInStock = 100,
                CreatedDate = DateTime.Now
            },
             new Enterprise
             {
                 Id = 8,
                 Name = "Core Purple Boot",
                 Description = "Running as admin worked for me after experiencing the same issue.",
                 Price = 17990,
                 PictureUrl = "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/",
                 Brand = "Net Core",
                 Type = "Boot",
                 QuantityInStock = 100,
                 CreatedDate = DateTime.Now
             },
             new Enterprise
             {
                 Id = 9,
                 Name = "Core Purple Boot",
                 Description = "Running as admin worked for me after experiencing the same issue.",
                 Price = 17990,
                 PictureUrl = "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/\"",
                 Brand = "Net Core",
                 Type = "Boot",
                 QuantityInStock = 100,
                 CreatedDate = DateTime.Now
             },
               new Enterprise
               {
                   Id = 10,
                   Name = "Core Purple Boot",
                   Description = "Running as admin worked for me after experiencing the same issue.",
                   Price = 17990,
                   PictureUrl = "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/",
                   Brand = "Net Core",
                   Type = "Boot",
                   QuantityInStock = 100,
                   CreatedDate = DateTime.Now
               }
          );
        }
    }
}
