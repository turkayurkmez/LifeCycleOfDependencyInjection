using LifeCycleOfDependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LifeCycleOfDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingleton singleton;
        private readonly IScoped scoped;
        private readonly ITransient transient;
        private readonly GuidService guidService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ISingleton singleton, IScoped scoped, ITransient transient, GuidService guidService)
        {
            this.singleton = singleton;
            this.scoped = scoped;
            this.transient = transient;
            this.guidService = guidService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Singleton = singleton.Guid.ToString();
            ViewBag.Scoped = scoped.Guid.ToString();
            ViewBag.Transient = transient.Guid.ToString();

            ViewBag.SingletonService = guidService.Singleton.ToString();
            ViewBag.ScopedService = guidService.Scoped.ToString();
            ViewBag.TransientService = guidService.Transient.ToString();

            return View();
        }

        public IActionResult Privacy()
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
