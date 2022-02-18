using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class FAQ
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100), Required]
        public string Question { get; set; }

        [MaxLength(1500), Required]
        public string Answer { get; set; }
    }
}
