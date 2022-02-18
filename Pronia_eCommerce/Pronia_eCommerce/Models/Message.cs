using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20), Required]
        public string FirstName { get; set; }

        [MaxLength(20), Required]
        public string LastName { get; set; }

        [MaxLength(50), Required]
        public string Email { get; set; }

        [MaxLength(25)]
        public string Phone { get; set; }

        [MaxLength(2000), Required]
        public string Content { get; set; }

        public bool hasReaded { get; set; }

        public DateTime CreatedDate { get; set; }



    }
}
