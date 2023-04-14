using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using SalesWebCafeteria.Context;
using System.Security.Cryptography.X509Certificates;

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
        string carrinhoId = session.GetString("CarrinhoId") ??Guid.NewGuid().ToString();

        // Retorna o carrinho com o contexto e o Id atribuido ou obtido
        return new CarrinhoCompra(context)
        {
            CarrinhoCompraId = carrinhoId
        };            
    
    }

    public void AdicionarCarrinho(Lanche lanche)
    {
        var carrinhoCompraItem = _context.CarrinhoCompraItens.SingleOrDefault(
            s => s.Lanche.LancheId == lanche.LancheId &&
            s.CarrinhoCompraId == CarrinhoCompraId);
        
        if (carrinhoCompraItem == null)
        {
            carrinhoCompraItem = new CarrinhoCompraItem
            {
                CarrinhoCompraId = CarrinhoCompraId,
                Lanche = lanche,
                Quantidade = 1
            };
        }
        
        else
        {
            carrinhoCompraItem.Quantidade++;
        }
        _context.SaveChanges();   
    }

    public void RemoverDoCarrinho(Lanche lanche)
    {
        var carrinhoCompraItem = _context.CarrinhoCompraItens.SingleOrDefault(
            s => s.Lanche.LancheId == lanche.LancheId &&
            s.CarrinhoCompraId == CarrinhoCompraId);

        if (carrinhoCompraItem != null)
        {
            if (carrinhoCompraItem.Quantidade > 1)
            {
                carrinhoCompraItem.Quantidade--;                
            }

            else
            {
                _context.CarrinhoCompraItens.Remove(carrinhoCompraItem);
            }
            _context.SaveChanges();
        }        
    }

    public List<CarrinhoCompraItem> GetCarrinhoCompraItems()
    {
        return CarrinhoCompraItems ??
            (CarrinhoCompraItems = _context.CarrinhoCompraItens
            .Where(s => s.CarrinhoCompraId == CarrinhoCompraId)
            .Include(s => s.Lanche)
            .ToList());
    }






}

