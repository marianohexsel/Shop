
using Shop.View.Model;

namespace Shop.View.Commands;

class GetShopListResult : CommandResult
{
    public List<ShopList> Data {get; set;} = null!;
}