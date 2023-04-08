using SalesWebCafeteria.Context;
using SalesWebCafeteria.Models;
using SalesWebCafeteria.Repository.Interfaces;

namespace SalesWebCafeteria.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
