using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GrandBlue.Models;

namespace GrandBlue.Data
{
    public class GrandBlueContext : DbContext
    {
        public GrandBlueContext (DbContextOptions<GrandBlueContext> options)
            : base(options)
        {
        }

        public DbSet<GrandBlue.Models.FrameData> FrameData { get; set; }

        public DbSet<GrandBlue.Models.Combo> Combo { get; set; }
    }
}
