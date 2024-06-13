using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExam.Entities
{
    internal class Product
    {
        [Key]public int Article { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; } 
        public string ImageUrl { get; set; } = string.Empty;
        public int Unit { get; set; } 
        public DateTime ManufactureDate  { get; set; } 
        public DateTime ExpiryDate { get; set; } 
        public string ManufactureCompany { get; set; } = string.Empty;
        public string ManufactureCountry { get; set; } = string.Empty;
        
        public List<Order> Orders { get; set; } = null!;
    }
}
