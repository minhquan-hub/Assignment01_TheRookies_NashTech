using System;

namespace Rookie.CustomerSite.ViewModel
{
    public class ProductVM
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}