using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoo_SoftToothbrush.Models
{
    public class BrushClass
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public decimal BrushSize { get; set; }

        public string Category { get; set; }
    }
}
