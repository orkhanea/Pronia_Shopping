﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class BlogTag
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(15)]
        public string TagName { get; set; }

        public List<BlogTagToBlog> BlogTagToBlogs { get; set; }
    }
}
