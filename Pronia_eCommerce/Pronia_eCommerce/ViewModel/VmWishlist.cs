using Pronia_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.ViewModel
{
    public class VmWishlist : VmLayout
    {
        public List<Product> Products { get; set; }
    }
}
