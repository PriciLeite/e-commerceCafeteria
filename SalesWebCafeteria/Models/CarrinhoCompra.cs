using SalesWebCafeteria.Context;

namespace SalesWebCafeteria.Models;

public class CarrinhoCompra
{
    private readonly AppDbContext _context;

    public CarrinhoCompra(AppDbContext context)
    {
        _context = context;
    }

    public string CarrinhoCompraId { get; set; }
    public List<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }

    public static CarrinhoCompra GetCarrinho(IServiceProvider services)
    {
        // define uma sessão
        ISession session = 
            services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
    
        // obter um serviço do tipo do nosso contexto  
        var context = services.GetService<AppDbContext>();

        // obter ou gerar o Id do carrinho
        string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

        // Retorna o carrinho com o contexto e o Id atribuido ou obtido
        return new CarrinhoCompra(context)
        {
            CarrinhoCompraId = carrinhoId
        };

    
    
    
    }

}

