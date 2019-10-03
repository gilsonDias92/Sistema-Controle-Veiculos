using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ControleVeiculos2019.Models
{
    [Table("CarBrand")]
    public class CarBrand
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string BrandName { get; set; }
        public string BrandInitials { get; set; }
    }
}