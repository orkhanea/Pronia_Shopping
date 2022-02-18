using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class Banner
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30), Required]
        public string Title { get; set; }

        [MaxLength(30), Required]
        public string Page { get; set; }

        [MaxLength(255)]
        public string BgImage { get; set; }

        [NotMapped]
        public IFormFile BgImageFile { get; set; }
    }
}
