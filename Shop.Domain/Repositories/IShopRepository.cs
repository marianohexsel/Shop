
using Shop.Domain.Entities;

namespace Shop.Domain.Repositories;
public interface IShopRepository
{
    void Create(ShopList shopList);
    void Update(ShopList shopList);
    void Delete(ShopList shopList);
    ShopList? GetShopListById(Guid id);
    IEnumerable<ShopList> GetAllShopList();
    void Create(ShopItem item);
    void Update(ShopItem item);
    void Delete(ShopItem item);
    ShopItem? GetShopItemById(Guid id);
    IEnumerable<ShopItem> GetAllShopItem(Guid shopListId);

}
