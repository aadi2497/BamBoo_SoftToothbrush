using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BamBoo_SoftToothbrush.Models;

namespace BamBoo_SoftToothbrush.Data
{
    public class BamBoo_SoftToothbrushContext : DbContext
    {
        public BamBoo_SoftToothbrushContext (DbContextOptions<BamBoo_SoftToothbrushContext> options)
            : base(options)
        {
        }

        public DbSet<BamBoo_SoftToothbrush.Models.BrushClass> BrushClass { get; set; }
    }
}
