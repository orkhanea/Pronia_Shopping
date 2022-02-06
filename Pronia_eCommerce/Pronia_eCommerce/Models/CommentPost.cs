using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class CommentPost
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20), Required]
        public string FullName { get; set; }

        [MaxLength(50), Required]
        public string Email { get; set; }

        [MaxLength(100)]
        public string Subject { get; set; }

        [MaxLength(2000), Required]
        public string Content { get; set; }

        [NotMapped]
        public int BlogId { get; set; }

        [NotMapped]
        public int CommentId { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<Comment> Comment { get; set; }

        public List<ProductComment> ProductComment { get; set; }

    }
}
