using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(1000)]
        public string FooterDesc { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        [MaxLength(25)]
        public string Copyright { get; set; }

        [MaxLength(250)]
        public string CopyrightLink { get; set; }

        [MaxLength(255)]
        public string Logo { get; set; }

        [NotMapped]
        public IFormFile LogoFile { get; set; }

        [MaxLength(255)]
        public string FooterBgImage { get; set; }

        [NotMapped]
        public IFormFile FooterBgImageFile { get; set; }
    }
}
