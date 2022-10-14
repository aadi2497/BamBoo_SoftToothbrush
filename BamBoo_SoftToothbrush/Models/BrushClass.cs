using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoo_SoftToothbrush.Models
{
    public class BrushClass
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        [Display(Name = "Size In CM")]
        public decimal BrushSize { get; set; }

        public string Category { get; set; }

        [Display(Name = "Bristles_Color")]
        public string Bristles_Color { get; set; }

        [Range(1,5)]
        public int Review { get; set;}

    }
}
