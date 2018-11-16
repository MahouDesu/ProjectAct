using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ActInteraction.ViewModels;
using ActInteraction.Models;


namespace ActInteraction.Controllers
{
    public class DamageController : Controller
    {
        public IActionResult Index()
        {
            DpsReader dpsReader = new DpsReader();
            ViewModel viewModels = new ViewModel();
            viewModels.DamageChart = dpsReader.GetDamage();

            return View(viewModels);
        }
    }
}