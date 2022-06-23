
using Shop.View.Model;

namespace Shop.View.Commands;

class GetShopListItemsResult : CommandResult
{
    public List<ShopItem> Data { get; set; } = null!;
}