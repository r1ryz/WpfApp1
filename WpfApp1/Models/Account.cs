using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace WpfApp1.Models
{
    internal class Account
    {
        [Key]
        public Guid IdAccount { get; set; }
        public Bill? Bill { get; set; }
        public String Name { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
    }
}
