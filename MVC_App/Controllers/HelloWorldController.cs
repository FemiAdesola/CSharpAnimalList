using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_App.Models;

namespace MVC_App.Controllers
{
    public class HelloWorldController : Controller
    {

        // for get an empty list
        private static List<AnimalViewModel> animals = new List<AnimalViewModel>();

        //


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(animals);
        }

        //// GET: /<controller>/
        //public IActionResult Index()
        //{
        //    AnimalViewModel dog = new AnimalViewModel()
        //    {
        //        Name= "Suzi",
        //        Age= 32,
        //        Description = "let see it"
        //    };
        //    return View(dog);
        //}


        // display form
        public IActionResult Create()
        {
            // for new aninmal
            var animalVm = new AnimalViewModel();
                //
            return View(animalVm);
        }

        // post the form
        public IActionResult CreateNewAnimal( AnimalViewModel animalViewModel)
        {
            //return View("Index");
            animals.Add(animalViewModel);
            return RedirectToAction(nameof(Index));
        }





        // GET: /<controller>/
        public string Hello()
        {
            return "Let's see it";
        }

    

        
     }
}

