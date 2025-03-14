﻿using Domain.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.Entities
{
    public class Brand : BaseEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string? Logo { get; set; }
        public string? Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
