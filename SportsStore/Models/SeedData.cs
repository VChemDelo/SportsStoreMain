using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if(!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A board for one person",
                        Category = "Watersports",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Lifeajcket",
                        Description = "Protective and fashionable",
                        Category = "Watersports",
                        Price = 48.95m
                    }, 
                    new Product
                    {
                        Name = "Soccer Ball",
                        Description = "Fifa-approved size and weight",
                        Category = "Soccer",
                        Price = 19.50m
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
