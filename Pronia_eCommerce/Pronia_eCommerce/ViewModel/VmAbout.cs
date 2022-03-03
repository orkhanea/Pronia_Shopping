using Pronia_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.ViewModel
{
    public class VmAbout :VmLayout
    {
        public List<OurBrand> OurBrands { get; set; }
        public Counter Counters { get; set; }
        public About About { get; set; }
        public Banner Banner { get; set; }
        public Counter Counter { get; set; }
        public List<SiteUser> OurTeam { get; set; }
    }
}
