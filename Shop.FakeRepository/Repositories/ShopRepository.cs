using Shop.Domain.Commands;
using Shop.Domain.Entities;
using Shop.Domain.Repositories;

namespace Shop.FakeRepository.Repositories;

public class ShopRepository : IShopRepository
{
    static private HashSet<ShopList> _shopListTable = new();
    static private HashSet<ShopItem> _shopItemTable = new();

    public ShopRepository()
    {
        if( _shopListTable.Any() ) return;
        var command = new CreateShopListCommand();
        command.Title = "Lista 01";
        Create( new ShopList(command) );
        command.Title = "Lista 02";
        Create( new ShopList(command) );
    }

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

    public IEnumerable<ShopList> GetAllShopList(IEnumerable<Guid> ids)
    {
        List<ShopList> list = new();
        foreach (var id in ids)
        {
            var item = GetShopListById(id);
            if(item is not null)
                list.Add(item);
        }
        return list;
    }
        
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