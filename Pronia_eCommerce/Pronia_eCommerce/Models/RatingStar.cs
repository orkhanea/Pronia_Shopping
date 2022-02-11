using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Models
{
    public class RatingStar
    {
        [Key]
        public int Id { get; set; }
        public int Star { get; set; }
        public string UserIp { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
