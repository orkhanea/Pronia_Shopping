using Microsoft.AspNetCore.Http;
using Pronia_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.ViewModel
{
    public class VmCreateProduct
    {
        public Product product { get; set; }
        public List<ProductSizeToProduct> productSizeToProduct { get; set; }
        public IFormFileCollection productImage { get; set; }
        public List<ProductSize> sizes { get; set; }


    }
}
