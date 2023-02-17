using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                        Price = 20.7M

                    },
                      new Pillow
                      {
                          material = "Cotton",
                          Types = "Pregnancy Pillow",
                          size = "Large",
                          color = "White",
                          Price = 55.7M
                    },


                    new Pillow
                    {
                        material = "Fiber",
                        Types = "Bed Pillow",
                        size = "Medium",
                        color = "gray",
                        Price = 25.6M
                    },


                    new Pillow
                    {
                        material = "Feather",
                        Types = "Body Pillows",
                        size = "Large",
                        color = "pink",
                        Price = 20.7M
                    },

                    new Pillow
                    {
                        material = "Foam",
                        Types = "Bed Pillows",
                        size = "Small",
                        color = "Red",
                        Price = 30.5M
                    },
                    new Pillow
                    {
                        material = "Water",
                        Types = "Bath Pillows",
                        size = "Medium",
                        color = "black",
                        Price = 40.8M
                    },
                     new Pillow
                     {
                         material = "Wool",
                         Types = "Travel Pillows",
                         size = "Medium",
                         color = "White",
                         Price = 25.7M
                    },
                    new Pillow
                    {
                        material = "Foam",
                        Types = "Body Pillows",
                        size = "Large",
                        color = "gray",
                        Price = 46.7M
                    },
                    new Pillow
                    {
                        material = "Fiber",
                        Types = "Contour Pillow",
                        size = "Medium",
                        color = "Purple",
                        Price = 23.7M
                    },
                    new Pillow
                    {
                        material = "Cotton",
                        Types = "Body Pillows",
                        size = "Large",
                        color = "yellow",
                        Price = 50.7M
                    }
                    );




                context.SaveChanges();
            }
        }
    }
}






