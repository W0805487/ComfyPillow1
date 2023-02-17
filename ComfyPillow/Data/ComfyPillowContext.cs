using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ComfyPillow.Models;

namespace ComfyPillow.Data
{
    public class ComfyPillowContext : DbContext
    {
        public ComfyPillowContext(DbContextOptions<ComfyPillowContext> options)
            : base(options)
        {

        }
        public DbSet<Pillow>Pillow  { get; set; }
    }
}
