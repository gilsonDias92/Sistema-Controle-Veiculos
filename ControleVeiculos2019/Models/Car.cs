using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ControleVeiculos2019.Models
{
    [Table("Car")]
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Modelo")]
        [Required(ErrorMessage ="Informe o modelo")]
        public string ModelName { get; set; }

        [DisplayName("Marca")]
        [Required(ErrorMessage = "Escolha a marca")]
        public int CarBrandId { get; set; }
        public CarBrand CarBrand { get; set; }

        [Range(1900, 2020, ErrorMessage = "Ano deve estar entre {1} e {2}")]
        [DisplayName("Ano")]
        [Required(ErrorMessage = "Informe o ano")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Informe o valor")]
        [DisplayName("Valor")]
        public decimal Price { get; set; }

        [DisplayName("Descrição")]
        public string Description { get; set; }

        [DisplayName("Imagem")]
        public string Image { get; set; }

        [Display(Name = "Adicionado em")]
        private DateTime? _addedDate = null;
        public DateTime DateAdded
        {
            get
            { 
                if (_addedDate.HasValue)
                    return _addedDate.Value;
                else
                    return DateTime.Now;
            }
            set => _addedDate = value;
        }
    }
}
