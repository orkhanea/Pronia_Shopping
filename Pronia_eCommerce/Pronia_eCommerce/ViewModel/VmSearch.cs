using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.ViewModel
{
    public class VmSearch
    {
        public int? SearchTag { get; set; }
        public int? SearchCategory { get; set; }
        public int? Page { get; set; }
        public string SearchData { get; set; }
    }
}
