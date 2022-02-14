using Pronia_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.ViewModel
{
    public class VmRegister:VmLayout
    {
        [MaxLength(30),Required]
        public string Name { get; set; }

        [MaxLength(30), Required]
        public string Surname { get; set; }

        [MaxLength(50), Required]
        public string Email { get; set; }

        [MaxLength(40), Required]
        public string Password { get; set; }

        [MaxLength(40), Required]
        public string ConfirmPassword { get; set; }
        public List<Country> Countries { get; set; }

        [MaxLength(20), Required]
        public string UserName { get; set; }

        [Required]
        public int CountryId { get; set; }

        public VmLogin VmLogin { get; set; }
    }
}
