using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string CountryName { get; set; }

        public List<EndUser> EndUsers { get; set; }
    }
}
