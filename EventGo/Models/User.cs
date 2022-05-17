using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGo.Models
{
    public class User : IdentityUser
    {
        [MaxLength(450)]
        public string Name { get; set; }
        [MaxLength(450)]
        public string Address { get; set; }
        [MaxLength(15)]
        public decimal Balance { get; set; }
    }
}
