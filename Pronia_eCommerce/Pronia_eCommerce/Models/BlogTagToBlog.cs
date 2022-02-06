using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class BlogTagToBlog
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("BlogTag")]
        public int BlogTagId { get; set; }
        public BlogTag BlogTag { get; set; }

        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
