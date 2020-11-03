using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ArkhamAdventure.Models;
using ArkhamAdventure.Models.ViewModels;
using ArkhamAdventure.Repository;

namespace ArkhamAdventure.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArkhamRepository repository;
       
        public HomeController(ILogger<HomeController> logger, IArkhamRepository repository)
        {
            _logger = logger;
            this.repository = repository;
        }

        public IActionResult Index(int? id)
        {
            var scenario = repository.GetScenario(id);
            scenario.Images = repository.GetImage(scenario.ImageID);
            scenario.Navigation = repository.GetNavButtons(scenario.NavigationId);
            scenario.Navigation.NavOptions = repository.GetNavOptions(scenario.NavigationId);
            


            return View(scenario);
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
