using ControleVeiculos2019.Models;
using ControleVeiculos2019.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleVeiculos2019.Controllers
{
    public class CarsController : Controller
    {
        //testing parameters
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var cars = new List<Car>
            {
                new Car{Id = 1, Name = "Car Number 1"},
                new Car{Id = 2, Name = "Car Number 2"},
                new Car{Id = 3, Name = "Car Number 3"},
                new Car{Id = 4, Name = "Car Number 4"},
                new Car{Id = 5, Name = "Car Number 5"}
            };

            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrEmpty(sortBy))
                sortBy = "Name";

            //return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

            return View(cars);
        }

        // GET: Cars/Random
        public ActionResult Random()
        {
            //vamos criar uma estancia da model car apenas para alguns testes
            var car = new Car
            {
                Id = 1,
                Name = "Corolla"
            };

            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "CustomerName1" },
                new Customer {Id = 2, Name = "CustomerName2" },
                new Customer {Id = 3, Name = "CustomerName3" }
            };

            //initializing it with the car previously instanciated and the list of customers above
            var viewModel = new RandomCarViewModel
            {
                Car = car,
                Customers = customers
            };

            // the viewModel will have with it the car and the customers
            return View(viewModel);     //or return new ViewResult();
        }

        public ActionResult Edit(int id)
        {
            return Content($"id = {id}");
        }

        [Route("movies/carsbyyear/{year:regex(\\d{4}):range(1980, 2020)}")]
        public ActionResult CarsByYear(int year)
        {
            return Content(year.ToString());
        }
    }
}