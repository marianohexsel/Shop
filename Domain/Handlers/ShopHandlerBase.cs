using Shop.Domain.Repositories;

namespace Shop.Domain.Handlers;
public class ShopHandlerBase 
{
    protected readonly IShopRepository _repository;

    public ShopHandlerBase(IShopRepository repository)
    {
        _repository = repository;
    }
}
