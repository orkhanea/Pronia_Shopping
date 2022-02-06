using Pronia_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.ViewModel
{
    public class VmBlog : VmLayout
    {
        public List<Blog> Blogs { get; set; }
        public Blog BlogDetail { get; set; }
        public CommentPost CommentPost { get; set; }
        public List<Blog> LatestBlogs { get; set; }
        public List<BlogCategory> BlogCategories { get; set; }
        public List<BlogTag> BlogTags { get; set; }
        public CollectionS CollectionS { get; set; }
        public VmSearch Search { get; set; }
        public Banner Banner { get; set; }
    }
}
