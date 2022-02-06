using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class ProductComment
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(1000)]
        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public byte RatingValue { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("CommentPost")]
        public int CommentPostId { get; set; }
        public CommentPost CommentPost { get; set; }

    }
}
