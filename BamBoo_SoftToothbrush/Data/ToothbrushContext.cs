using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BamBoo_SoftToothbrush.Models;

namespace BamBoo_SoftToothbrush.Data
{
    public class ToothbrushContext : DbContext
    {
        public ToothbrushContext (DbContextOptions<ToothbrushContext> options):base(options)
        {

        }
        public DbSet<BrushClass> BrushClass { get; set; }
    }
}
