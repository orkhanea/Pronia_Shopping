using Pronia_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.ViewModel
{
    public class VmAdminHome
    {
        public List<Sale> Sales { get; set; }
        public List<int> Datas { get; set; }
        public List<IEnumerable<DateTime>> Dates { get; set; }
        public List<decimal> Total { get; set; }
    }
}
