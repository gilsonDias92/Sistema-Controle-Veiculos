using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleVeiculos2019.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public bool IsSubscribed { get; set; }
        public CustomerType CustomerType { get; set; }
        public byte CustomerTypeId { get; set; }
    }
}