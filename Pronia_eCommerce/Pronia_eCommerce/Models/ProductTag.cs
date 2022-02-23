﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class ProductTag
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(15), Required]
        public string TagName { get; set; }

        public List<ProductTagToProduct> ProductTagToProducts { get; set; }
    }
}
