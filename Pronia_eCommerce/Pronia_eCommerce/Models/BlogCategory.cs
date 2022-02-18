using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class BlogCategory
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(15), Required]
        public string CategoryName { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
