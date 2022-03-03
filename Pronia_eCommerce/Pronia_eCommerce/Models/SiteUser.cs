using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class SiteUser : IdentityUser
    {
        [MaxLength(30), Required]
        public string Name { get; set; }

        [MaxLength(30),Required]
        public string Surname { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [MaxLength(250)]
        public string BgImage { get; set; }

        [NotMapped]
        public IFormFile BgImageFile { get; set; }

        [MaxLength(200)]
        public string UserInfo { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime BDate { get; set; }

        [NotMapped]
        public string RoleId { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
