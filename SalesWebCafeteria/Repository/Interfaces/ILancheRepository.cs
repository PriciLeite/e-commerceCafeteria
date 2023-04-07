using SalesWebCafeteria.Models;

namespace SalesWebCafeteria.Repository.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
    }
}
