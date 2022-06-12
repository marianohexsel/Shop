using Shop.Domain.Entities;
using Shop.Domain.Repositories;

namespace Shop.FakeRepository.Repositories;

public class ShopRepository : IShopRepository
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