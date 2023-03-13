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
    internal class Bill
    {
        [Key]
        public Guid IdBill { get; set; }
        public double Balance { get; set; }
    }
}
