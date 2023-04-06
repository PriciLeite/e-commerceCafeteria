using SalesWebCafeteria.Models;

namespace SalesWebCafeteria.Repository.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
