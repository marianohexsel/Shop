
using Shop.Domain.Entities;

namespace Shop.Domain.Repositories;
public interface IShopRepository
{
    void Create(ShopItem item);
    void Update(ShopItem item);
}
