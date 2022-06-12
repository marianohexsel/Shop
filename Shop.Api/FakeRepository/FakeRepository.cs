using Shop.Domain.Entities;
using Shop.Domain.Repositories;

namespace Shop.Api.FakeRepository;

public class FakeRepository : IShopRepository
{
    public void Create(ShopList shopList)
    {
    }

    public void Update(ShopList shopList)
    {
    }

    void IShopRepository.Create(ShopItem item)
    {
        
    }

    void IShopRepository.Update(ShopItem item)
    {
        
    }
}