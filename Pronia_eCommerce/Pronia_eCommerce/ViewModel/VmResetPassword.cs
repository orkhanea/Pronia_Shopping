using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.ViewModel
{
    public class VmResetPassword:VmLayout
    {
        [Required]
        public string Email { get; set; }
    }
}
