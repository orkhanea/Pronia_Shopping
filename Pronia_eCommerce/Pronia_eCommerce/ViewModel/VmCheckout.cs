using Pronia_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.ViewModel
{
    public class VmCheckout:VmLayout
    {
        public VmPayment vmPayment { get; set; }
        public List<ProductSizeToProduct> prstp { get; set; }
        public List<string> Messages = new();
        public List<int> prqty = new();


    }
}
