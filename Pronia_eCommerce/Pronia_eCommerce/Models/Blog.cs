using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "ntext"), Required]
        public string Content { get; set; }

        [MaxLength(200), Required]
        public string ShortDesc { get; set; }

        [MaxLength(50), Required]
        public string Title { get; set; }

        [MaxLength(255)]
        public string VideoLink { get; set; }

        [MaxLength(255)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [MaxLength(150)]
        public string Quote { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("Category")]
        public int? BlogCategoryId { get; set; }
        public BlogCategory Category { get; set; }

        public List<BlogTagToBlog> BlogTagToBlogs { get; set; }
        public List<Comment> Comments { get; set; }

        [NotMapped]
        public List<int> BlogTagToBlogId { get; set; }
    }
}
