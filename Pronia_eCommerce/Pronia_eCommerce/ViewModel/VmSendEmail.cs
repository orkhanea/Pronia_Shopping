using Pronia_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.ViewModel
{
    public class VmSendEmail
    {
        public Message message { get; set; }

        [Required]
        public string sendingMessage { get; set; }

        [Required]
        public string EmailAddress { get; set; }
    }
}
