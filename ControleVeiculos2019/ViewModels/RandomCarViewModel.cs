using ControleVeiculos2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleVeiculos2019.ViewModels
{
    public class RandomCarViewModel
    {
        public Car Car { get; set; }
        public List<Customer> Customers { get; set; }
    }
}