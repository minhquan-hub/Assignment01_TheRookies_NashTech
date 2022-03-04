using System;
using Rookie.CustomerSite.ViewModel.Image;

namespace Rookie.CustomerSite.ViewModel.Product
{
    public class ProductVM<TViewModel>
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public TViewModel  Image { get; set; }
    }
}