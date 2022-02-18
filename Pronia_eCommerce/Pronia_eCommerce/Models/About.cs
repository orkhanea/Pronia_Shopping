using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Desc { get; set; }

        [MaxLength(255), Required]
        public string VideoLink { get; set; }

        [MaxLength(255)]
        public string Signature { get; set; }

        [NotMapped]
        public IFormFile SignatureFile { get; set; }
    }
}
