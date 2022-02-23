using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50), Required]
        public string Name { get; set; }

        [MaxLength(500), Required]
        public string ShortDesc { get; set; }

        [MaxLength(20)]
        public string SKU { get; set; }

        [Required]
        public string FullDesc { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<Comment> Comment { get; set; }

        [ForeignKey("ProductCat")]
        public int ProductCatId { get; set; }
        public ProductCat ProductCat { get; set; }

        [NotMapped]
        public List<int> ProductTagToProductId { get; set; }

        public List<ProductTagToProduct> ProductTagToProducts { get; set; }
        public List<ProductComment> ProductComments { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<ProductSizeToProduct> ProductSizeToProducts { get; set; }
        public List<RatingStar> Ratings { get; set; }


    }
}
