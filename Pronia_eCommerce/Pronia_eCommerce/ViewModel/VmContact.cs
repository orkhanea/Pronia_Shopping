using Pronia_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.ViewModel
{
    public class VmContact : VmLayout
    {
        public ContactUs ContactUs { get; set; }
        public Message Message { get; set; }
        public Banner Banner { get; set; }
    }
}
