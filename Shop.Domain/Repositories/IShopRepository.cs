
using Shop.Domain.Entities;

namespace Shop.Domain.Repositories;
public interface IShopRepository
{
    void Create(ShopList shopList);
    void Update(ShopList shopList);
    void Create(ShopItem item);
    void Update(ShopItem item);
}
