using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class EndUser : IdentityUser
    {

        [MaxLength(20), Required]
        public string Name { get; set; }

        [MaxLength(20), Required]
        public string Surname { get; set; }

        [MaxLength(100), Required]
        public string ShippingAddress { get; set; }

        [MaxLength(100), Required]
        public string BillingAddress { get; set; }

        public DateTime CreatedDate { get; set; }

        [MaxLength(255)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public List<Sale> Sales { get; set; }

        [MaxLength(500)]
        public string ResetPasswordCode { get; set; }

        public List<Comment> Comment { get; set; }

        public List<ProductComment> ProductComments { get; set; }
    }
}
