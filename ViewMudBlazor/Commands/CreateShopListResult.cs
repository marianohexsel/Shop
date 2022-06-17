
using Shop.View.Model;

namespace Shop.View.Commands;

class CreateShopListResult : CommandResult
{
    public ShopList Data {get; set;} = null!;
}