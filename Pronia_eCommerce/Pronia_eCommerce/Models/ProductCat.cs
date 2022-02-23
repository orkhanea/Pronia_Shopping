using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class ProductCat
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20), Required]
        public string CategoryName { get; set; }

        public List<Product> Products { get; set; }
    }
}
