using SalesWebCafeteria.Models;
using SalesWebCafeteria.Repository.Interfaces;

namespace SalesWebCafeteria.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ICategoriaRepository _context;

        public CategoriaRepository(ICategoriaRepository context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
