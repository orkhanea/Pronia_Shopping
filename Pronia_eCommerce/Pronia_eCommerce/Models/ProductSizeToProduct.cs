using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class ProductSizeToProduct
    {
        [Key]
        public int Id { get; set; }

        public decimal Price { get; set; }

        public byte Quantity { get; set; }

        [ForeignKey("ProductSize")]
        public int ProductSizeId { get; set; }
        public ProductSize ProductSize { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public List<SaleItem> SaleItems { get; set; }
    }
}
