using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class Counter
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        public string Desc { get; set; }

        public int Project { get; set; }

        public int Client { get; set; }

        public int Rating { get; set; }

        public int Award { get; set; }

    }
}
