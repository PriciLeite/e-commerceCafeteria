using Microsoft.AspNetCore.Mvc;
using SalesWebCafeteria.Models;
using SalesWebCafeteria.Models.ViewModels;
using SalesWebCafeteria.Repository.Interfaces;
using System.Diagnostics;

namespace SalesWebCafeteria.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public HomeController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }


        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                LanchesPreferidos = _lancheRepository.LanchesPreferidos
            };
            return View(homeViewModel);
        }
        



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}