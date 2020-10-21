using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmploymentApp.Models;
using EmploymentApp.Models.Models;

namespace EmploymentApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]  
        [ValidateAntiForgeryToken]  
        public IActionResult New(Applicant applicant)  
        {  
            if (ModelState.IsValid)  
            {  
                RedirectToAction("Index");  
            }  
            return View();  
        }  
    }
}
