using Pronia_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.ViewModel
{
    public class VmHome :VmLayout
    {
        public List<OurBrand> OurBrands { get; set; }
        public List<CollectionL> CollectionL { get; set; }
        public List<CollectionS> CollectionS { get; set; }
        public List<Blog> LatestBlogs { get; set; }
    }
}
