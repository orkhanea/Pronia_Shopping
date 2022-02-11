using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pronia_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions option) : base(option)
        {
        
        }

        public DbSet<About> About { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<BlogTagToBlog> BlogTagToBlogs { get; set; }
        public DbSet<CollectionL> CollectionL { get; set; }
        public DbSet<CollectionS> CollectionS { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentPost> CommentPosts { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Counter> Counters { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<EndUser> EndUsers { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<HomeSlider> HomeSliders { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<OurBrand> OurBrands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<ProductSizeToProduct> ProductSizeToProducts { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<ProductTagToProduct> ProductTagToProducts { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<SiteSocial> SiteSocials { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<ProductCat> ProductCats { get; set; }
        public DbSet<RatingStar> RatingStars { get; set; }
    }
}
