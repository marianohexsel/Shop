using Shop.Domain.Entities;
using Shop.Domain.Repositories;

namespace Shop.FakeRepository.Repositories;

public class ShopRepository : IShopRepository
{
    private HashSet<ShopList> _shopListTable = new();
    private HashSet<ShopItem> _shopItemTable = new();

    public void Create(ShopList shopList) =>
        _shopListTable.Add(shopList);

    public void Update(ShopList shopList)
    {
        _shopListTable.Remove(shopList);
        _shopListTable.Add(shopList);
    }

    public void Delete(ShopList shopList) =>
        _shopListTable.Remove(shopList);

    public ShopList? GetShopListById(Guid id) =>
        _shopListTable.Where(x => x.Id == id).FirstOrDefault();

    public IEnumerable<ShopList> GetAllShopList() =>
        _shopListTable;

    void IShopRepository.Create(ShopItem item) =>
        _shopItemTable.Add(item);

    void IShopRepository.Update(ShopItem item)
    {
        _shopItemTable.Remove(item);
        _shopItemTable.Add(item);
    }
    public void Delete(ShopItem item) =>
        _shopItemTable.Remove(item);

    public ShopItem? GetShopItemById(Guid id) =>
        _shopItemTable.Where(x => x.Id == id).FirstOrDefault();

    public IEnumerable<ShopItem> GetAllShopItem(Guid shopListId) =>
        _shopItemTable.Where(item => item.ShopListId == shopListId);


}