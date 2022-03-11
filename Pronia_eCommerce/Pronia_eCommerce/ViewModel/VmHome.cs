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
        public List<Product> LatestProducts { get; set; }
        public List<Product> RatingProducts { get; set; }
        public List<Product> Products { get; set; }
        public List<string> Favourite { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<HomeSlider> HomeSliders { get; set; }
    }
}
