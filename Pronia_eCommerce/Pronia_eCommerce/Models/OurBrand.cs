using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class OurBrand
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(255)]
        public string BrandLogo { get; set; }

        [NotMapped]
        public IFormFile BrandLogoFile { get; set; }
    }
}
