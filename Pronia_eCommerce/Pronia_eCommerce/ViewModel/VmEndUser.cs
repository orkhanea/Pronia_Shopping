using Pronia_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.ViewModel
{
    public class VmEndUser : VmLayout
    {
        public EndUser EndUser { get; set; }
        public List<Country> Countries { get; set; }
        public Banner Banner { get; set; }

    }
}
