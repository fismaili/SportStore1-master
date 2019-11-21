using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore1.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if(!context.Products.Any())
            {
                context.Products.AddRange(
                  new Product { Name="test",Description="test description",Price=15,Category="Tenis"},
                  new Product { Name = "test1", Description = "tes1t description", Price = 16, Category = "Tenis1" },
                  new Product { Name = "test2", Description = "test2 description", Price = 17, Category = "Tenis2" },
                  new Product { Name = "test3", Description = "test3 description", Price = 18, Category = "Tenis3" }



                    );
            }

            context.SaveChanges();
        }
    }
}
