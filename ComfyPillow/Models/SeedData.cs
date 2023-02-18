using System;

using System.Linq;
using ComfyPillow.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ComfyPillow.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ComfyPillowContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ComfyPillowContext>>()))
            {
                // Look for any pillows.
                if (context.Pillow.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pillow.AddRange(
                    new Pillow
                    {
                        material = "Foam ",
                        Types = "Bed Pillows",
                        size = "Medium",
                        color = "White",
                        Rating = 5,
                        Price = 20.7M
                       

                    },
                      new Pillow
                      {
                          material = "Cotton",
                          Types = "Pregnancy Pillow",
                          size = "Large",
                          color = "White",
                          Rating = 5,
                          Price = 55.7M
                          
                      },


                    new Pillow
                    {
                        material = "Fiber",
                        Types = "Bed Pillow",
                        size = "Medium",
                        color = "gray",
                        Rating = 5,
                        Price = 25.6M
                        
                    },


                    new Pillow
                    {
                        material = "Feather",
                        Types = "Body Pillows",
                        size = "Large",
                        color = "pink",
                        Rating = 5,
                        Price = 20.7M
                        
                    },

                    new Pillow
                    {
                        material = "Foam",
                        Types = "Bed Pillows",
                        size = "Small",
                        color = "Red",
                        Rating = 5,
                        Price = 30.5M
                       
                    },
                    new Pillow
                    {
                        material = "Water",
                        Types = "Bath Pillows",
                        size = "Medium",
                        color = "black",
                        Rating = 5,
                        Price = 40.8M
                       
                    },
                     new Pillow
                     {
                         material = "Wool",
                         Types = "Travel Pillows",
                         size = "Medium",
                         color = "White",
                         Rating = 5,
                         Price = 25.7M
                         
                     },
                    new Pillow
                    {
                        material = "Foam",
                        Types = "Body Pillows",
                        size = "Large",
                        color = "gray",
                        Rating = 5,
                        Price = 46.7M
                        
                    },
                    new Pillow
                    {
                        material = "Fiber",
                        Types = "Contour Pillow",
                        size = "Medium",
                        color = "Purple",
                        Rating = 5,
                        Price = 23.7M
                        
                    },
                    new Pillow
                    {
                        material = "Cotton",
                        Types = "Body Pillows",
                        size = "Large",
                        color = "yellow",
                        Rating = 5,
                        Price = 50.7M
                        
                    }
                    );




                context.SaveChanges();
            }
        }
    }
}






