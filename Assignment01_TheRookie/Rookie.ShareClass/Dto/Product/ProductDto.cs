using System;

namespace Rookie.ShareClass.Dto.Product {

    public class ProductDto : BaseQueryCriteriaDto {
        
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}