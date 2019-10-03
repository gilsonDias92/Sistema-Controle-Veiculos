using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleVeiculos2019.Models
{
    public class CustomerType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}