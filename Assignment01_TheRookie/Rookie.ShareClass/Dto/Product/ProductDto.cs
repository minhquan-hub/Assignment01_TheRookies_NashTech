using System;
using Rookie.ShareClass.Dto.Image;

namespace Rookie.ShareClass.Dto.Product {

    public class ProductDto<TModel> 
    {
        
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CateId { get; set; }
        public TModel Image { get; set; }
    }
}