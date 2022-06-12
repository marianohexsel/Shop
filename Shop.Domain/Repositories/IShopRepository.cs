
using Shop.Domain.Entities;

namespace Shop.Domain.Repositories;
public interface IShopRepository
{
    void Create(ShopList shopList);
    void Update(ShopList shopList);
    IEnumerable<ShopList> GetAllShopList();
    void Create(ShopItem item);
    void Update(ShopItem item);
    IEnumerable<ShopItem> GetAllShopItem(Guid shopListId);

}
