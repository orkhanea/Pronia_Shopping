using Pronia_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.ViewModel
{
    public class VmProduct : VmLayout
    {
        public List<Product> Products { get; set; }
        public List<ProductSizeToProduct> productSizeToProducts { get; set; }
        public Banner Banner { get; set; }
        public VmProductSearch Search { get; set; }
        public List<ProductCat> ProductCats { get; set; }
        public List<ProductTag> ProductTags { get; set; }
        public List<ProductSize> ProductSizes { get; set; }
        public Product SingleProduct { get; set; }
        public CommentPost CommentPost { get; set; }
        public List<RatingStar> RatingStars { get; set; }
        public List<string> Favourite { get; set; }
        public CollectionS collectionS { get; set; }
    }
}
