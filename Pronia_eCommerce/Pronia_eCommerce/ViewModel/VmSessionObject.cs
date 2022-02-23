using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.ViewModel
{
    public class VmSessionObject
    {
        public List<int> ProductId = new();
        public List<int> ProductSizeToProductId = new();
        public List<int> ProductCount = new();
        public List<string> Messages = new();
    }
}
