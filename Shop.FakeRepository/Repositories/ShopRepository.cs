using Shop.Domain.Entities;
using Shop.Domain.Repositories;

namespace Shop.FakeRepository.Repositories;

public class ShopRepository : IShopRepository
{
    public void Create(ShopList shopList)
    {
    }

    public IEnumerable<ShopItem> GetAllShopItem(Guid shopListId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ShopList> GetAllShopList()
    {
        throw new NotImplementedException();
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