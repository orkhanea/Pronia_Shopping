using Pronia_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.ViewModel
{
    public class VmCart : VmLayout
    {
        public List<Product> Products { get; set; }
        public List<int> ProductIds { get; set; }
        public List<int> ProductSizeIds { get; set; }
        public List<int> ProductCounts { get; set; }



    }
}
