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
                        ProductName = "BamBoo Soft 1",
                        Price = 5.99,
                        BrushSize = 55M,
                        Category = "Adult",
                        Bristles_Color = "Black",
                        Review = 4
                    },
                    new BrushClass
                    {
                        ProductName = "BamBoo Soft 2",
                        Price = 6.99,
                        BrushSize = 45M,
                        Category =,
                        Bristles_Color =,
                        Review =
                    },
                    new BrushClass
                    {
                        ProductName = "",
                        Price =,
                        BrushSize =,
                        Category =,
                        Bristles_Color =,
                        Review =
                    },
                    new BrushClass
                    {
                        ProductName = "",
                        Price =,
                        BrushSize =,
                        Category =,
                        Bristles_Color =,
                        Review =
                    },
                    new BrushClass
                    {
                        ProductName = "",
                        Price =,
                        BrushSize =,
                        Category =,
                        Bristles_Color =,
                        Review =
                    },
                    new BrushClass
                    {
                        ProductName = "",
                        Price =,
                        BrushSize =,
                        Category =,
                        Bristles_Color =,
                        Review =
                    },
                    new BrushClass
                    {
                        ProductName = "",
                        Price =,
                        BrushSize =,
                        Category =,
                        Bristles_Color =,
                        Review =
                    },
                    new BrushClass
                    {
                        ProductName = "",
                        Price =,
                        BrushSize =,
                        Category =,
                        Bristles_Color =,
                        Review =
                    },
                    new BrushClass
                    {
                        ProductName = "",
                        Price =,
                        BrushSize =,
                        Category =,
                        Bristles_Color =,
                        Review =
                    },
                    new BrushClass
                    {
                        ProductName = "",
                        Price =,
                        BrushSize =,
                        Category =,
                        Bristles_Color =,
                        Review =
                    }
                    );                    
                context.SaveChanges();
            }
        }
    }
}
