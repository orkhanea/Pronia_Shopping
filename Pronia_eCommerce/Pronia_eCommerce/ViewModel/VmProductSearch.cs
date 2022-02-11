using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.ViewModel
{
    public class VmProductSearch
    {
        public int? SearchTag { get; set; }
        public int? SearchCategory { get; set; }
        public int? SearchSize { get; set; }
        public int? Page { get; set; }
        public string SearchData { get; set; }
        public bool? OrderByDate { get; set; }
        public int? minValue { get; set; }
        public int? maxValue { get; set; }
    }
}
