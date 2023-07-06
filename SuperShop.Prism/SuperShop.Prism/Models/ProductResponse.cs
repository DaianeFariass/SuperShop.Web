using System;
using System.Collections.Generic;
using System.Text;

namespace SuperShop.Prism.Models
{
    public class ProductResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public Guid ImageId { get; set; }

        public DateTime? LastPurchase { get; set; }


        public DateTime? LastSale { get; set; }


        public bool IsAvailable { get; set; }

        
        public double Stock { get; set; }

        public UserResponse User { get; set; }

        public string ImageFullPath { get; set; }
    }
}
