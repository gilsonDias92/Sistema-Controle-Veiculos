using ControleVeiculos2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleVeiculos2019.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars/Random
        public ActionResult Random()
        {
            //vamos criar uma estancia da model car apenas para alguns testes

            var car = new Car
            {
                Id = 1,
                Name = "Corolla"
            };

            //retorna uma view renderizando o obj
            return View(car);
        }
    }
}