using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class Testimonial
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20), Required]
        public string Name { get; set; }

        [MaxLength(20), Required]
        public string Surname { get; set; }

        [MaxLength(20), Required]
        public string Status { get; set; }

        [MaxLength(108), Required]
        public string Message { get; set; }

        [MaxLength(210)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
