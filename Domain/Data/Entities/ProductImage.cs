﻿using Domain.Data.Base;

namespace Domain.Data.Entities
{
    public class ProductImage : BaseEntity
    {
        public int ProductImageId { get; set; }
        public Guid? ProductId { get; set; }
        public int? ProductVariationId { get; set; }
        public string ImageUrl { get; set; }
        public Product? Product { get; set; }
        public ProductVariations? ProductVariation { get; set; }
    }
}