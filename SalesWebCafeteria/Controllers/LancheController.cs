using Microsoft.AspNetCore.Mvc;
using SalesWebCafeteria.Models.ViewModels;
using SalesWebCafeteria.Repository.Interfaces;

namespace SalesWebCafeteria.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            /* ViewData["Titulo"] = "Cardápio";
             ViewData["Data"] = DateTime.Now; 

             var lanches = _lancheRepository.Lanches;
             var totalLanches = lanches.Count();

             ViewBag.Total = "Total Disponíveis: ";
             ViewBag.totalLanches = totalLanches;

             return View(lanches); */

            var lanchesListViewModels = new LancheListViewModel();
            lanchesListViewModels.lanches = _lancheRepository.Lanches;
            lanchesListViewModels.CategoriaAtual = "Categoria Atual";
            return View(lanchesListViewModels);

        }
    
        
       
    
    
    }
}
