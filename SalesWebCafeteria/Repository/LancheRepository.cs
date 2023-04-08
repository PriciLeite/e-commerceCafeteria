using SalesWebCafeteria.Models;
using SalesWebCafeteria.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;


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

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(l => l.IsLanchePreferido);


        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    
    
    
    }
}
