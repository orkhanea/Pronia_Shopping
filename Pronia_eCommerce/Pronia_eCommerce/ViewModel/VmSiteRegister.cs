using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.ViewModel
{
    public class VmSiteRegister
    {
        [MaxLength(30), Required]
        public string Name { get; set; }

        [MaxLength(30), Required]
        public string Surname { get; set; }

        [MaxLength(50), Required]
        public string Email { get; set; }

        [MaxLength(40), Required]
        public string Password { get; set; }

        [Required]
        public string RoleId { get; set; }
    }
}
