using SalesWebCafeteria.Models;
using SalesWebCafeteria.Repository.Interfaces;

namespace SalesWebCafeteria.Repository
{
    public class LancheRepository : ILancheRepository
    {
        private readonly ILancheRepository _context;

        public LancheRepository(ILancheRepository context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches;
    }
}
