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
            using (var context = new BamBoo_SoftToothbrushContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BamBoo_SoftToothbrushContext>>()))
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
                        Category = "Adult",
                        Bristles_Color = "White",
                        Review = 4
                    },
                    new BrushClass
                    {
                        ProductName = "BamBoo Soft Max",
                        Price = 12.99,
                        BrushSize = 45M,
                        Category = "Kids",
                        Bristles_Color = "Pink",
                        Review = 3
                    },
                    new BrushClass
                    {
                        ProductName = "BamBoo Soft Ultra",
                        Price = 16.99,
                        BrushSize = 25M,
                        Category = "Kids",
                        Bristles_Color = "Black",
                        Review = 3
                    },
                    new BrushClass
                    {
                        ProductName = "Bamboo Max",
                        Price =12.99,
                        BrushSize =60M,
                        Category = "Kids",
                        Bristles_Color = "Blue",
                        Review = 5
                    },
                    new BrushClass
                    {
                        ProductName = "BamBoo Zen",
                        Price = 10.99,
                        BrushSize = 65M,
                        Category = "Kids",
                        Bristles_Color ="White",
                        Review = 3
                    },
                    new BrushClass
                    {
                        ProductName = "Bamboo Soft",
                        Price = 3.99,
                        BrushSize = 85M,
                        Category = "Kids",
                        Bristles_Color ="Brown",
                        Review = 2
                    },
                    new BrushClass
                    {
                        ProductName = "BamBoo Pro",
                        Price = 6.99,
                        BrushSize = 35M,
                        Category = "Adult",
                        Bristles_Color ="Red",
                        Review =2
                    },
                    new BrushClass
                    {
                        ProductName = "BamBoo Crafted",
                        Price =8.99,
                        BrushSize =25M,
                        Category = "Adult",
                        Bristles_Color ="Red",
                        Review =2
                    },
                    new BrushClass
                    {
                        ProductName = "Sof Gen BamBoo",
                        Price =5.99,
                        BrushSize =55M,
                        Category = "Adult",
                        Bristles_Color ="Black",
                        Review =5
                    }
                    );                    
                context.SaveChanges();
            }
        }
    }
}
