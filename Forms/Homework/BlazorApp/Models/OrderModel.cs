using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class OrderModel
    {
        [Required]
        public int MilkshakeType { get; set; }
        [Required]
        public int MilkshakeSize { get; set; }
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        [Required]
        [Range(1, 100)]
        public int Quantity { get; set; }
        public bool WhippedCream { get; set; }
    }
}
