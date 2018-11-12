using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ActInteraction.Controllers
{
    public class DamageController : Controller
    {
        public IActionResult Index()
        {
            DpsReader dpsReader = new DpsReader();


            return View();
        }
    }
}