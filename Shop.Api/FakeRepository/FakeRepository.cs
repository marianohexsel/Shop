using Shop.Domain.Entities;
using Shop.Domain.Repositories;

namespace Shop.Api.FakeRepository;

public class FakeRepository : IShopRepository
{
    void IShopRepository.Create(ShopItem item)
    {
        
    }

    void IShopRepository.Update(ShopItem item)
    {
        
    }
}