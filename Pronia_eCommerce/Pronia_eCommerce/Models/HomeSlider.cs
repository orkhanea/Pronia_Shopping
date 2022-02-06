using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class HomeSlider
    {
        [Key]
        public int Id { get; set; }

        public byte Discount { get; set; }

        [MaxLength(30)]
        public string Title { get; set; }

        [MaxLength(30)]
        public string SubTitle { get; set; }

        [MaxLength(255)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
