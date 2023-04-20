using Microsoft.AspNetCore.Mvc;
using SalesWebCafeteria.Models;
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

        public IActionResult List(string categoria)
        {
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;
            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os Lanches";
            }
            else
            {
                if (string.Equals("Paes Salgados", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepository.Lanches
                        .Where(l => l.Categoria.CategoriaNome.Equals("Paes Salgados"))
                        .OrderBy(l => l.LancheId);
                }
                else
                {
                    lanches = _lancheRepository.Lanches
                        .Where(l => l.Categoria.CategoriaNome.Equals("Paes Doces"))
                        .OrderBy(l => l.LancheId);
                }
                categoriaAtual = categoria;
            }
            var lanchesListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };

            return View(lanchesListViewModel);

            /* ViewData["Titulo"] = "Cardápio";
             ViewData["Data"] = DateTime.Now; 

             var lanches = _lancheRepository.Lanches;
             var totalLanches = lanches.Count();

             ViewBag.Total = "Total Disponíveis: ";
             ViewBag.totalLanches = totalLanches;

             return View(lanches); */



        }





    }
}
