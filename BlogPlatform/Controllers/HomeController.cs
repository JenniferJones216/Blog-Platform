using BlogPlatform.Models;
using BlogPlatform.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Controllers
{
    public class HomeController : Controller
    {
        
        public HomeController()
        {

        }
        public IActionResult Index()
        {
            //var listOfContents = _contentRepo.GetAll();
            return View();
        }
    }
}
