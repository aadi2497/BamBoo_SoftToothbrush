using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BamBoo_SoftToothbrush.Data;
using System;
using System.Linq;


namespace BamBoo_SoftToothbrush.Models

{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ToothbrushContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ToothbrushContext>>()))
            {
                // Look for any Entry in Database.
                if (context.BrushClass.Any())
                {
                    return; //Seeded Data from Database
                }
                context.BrushClass.AddRange(
                    new BrushClass
                    {
                        ProductName ="",
                        Price=,
                        BrushSize=,
                        Category=,
                        Bristles_Color=,
                        Review=
                    }
                    );                    
                context.SaveChanges();
            }
        }
    }
}
