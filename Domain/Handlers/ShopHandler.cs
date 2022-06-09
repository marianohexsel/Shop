using Shop.Domain.Repositories;

namespace Shop.Domain.Handlers;
public partial class ShopHandler : ShopHandlerBase
{
    public ShopHandler(IShopRepository repository) : base(repository)
    {
    }
}