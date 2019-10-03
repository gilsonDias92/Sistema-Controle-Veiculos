using ControleVeiculos2019.Models;
using ControleVeiculos2019.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleVeiculos2019.Controllers
{
    public class CarsController : Controller
    {
        ApplicationDbContext _context;

        public CarsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //testing parameters
        public ActionResult Index()
        {
            var cars = _context.Cars.Include(c => c.CarBrand).ToList();
            return View(cars);
        }

        public ActionResult Details(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (car == null)
                return HttpNotFound();

            return View(car);
        }



        // GET: Cars/Random
        //public ActionResult Random()
        //{
        //    //vamos criar uma estancia da model car apenas para alguns testes
        //    var car = new Car
        //    {
        //        Id = 1,
        //        Name = "Corolla"
        //    };

        //    var customers = new List<Customer>
        //    {
        //        new Customer {Id = 1, Name = "CustomerName1" },
        //        new Customer {Id = 2, Name = "CustomerName2" },
        //        new Customer {Id = 3, Name = "CustomerName3" }
        //    };

        //    //initializing it with the car previously instanciated and the list of customers above
        //    var viewModel = new RandomCarViewModel
        //    {
        //        Car = car,
        //        Customers = customers
        //    };

        //    // the viewModel will have with it the car and the customers
        //    return View(viewModel);     //or return new ViewResult();
        //}

        //public ActionResult Edit(int id)
        //{
        //    return Content($"id = {id}");
        //}

        //[Route("movies/carsbyyear/{year:regex(\\d{4}):range(1980, 2020)}")]
        //public ActionResult CarsByYear(int year)
        //{
        //    return Content(year.ToString());
        //}
    }
}