
using Shop.Domain.Commands;
using Shop.Domain.Entities;
using Shop.Domain.Handlers.Contracts;

namespace Shop.Domain.Handlers;

public partial class ShopHandler : ShopHandlerBase, IHandler<CreateShopListCommand>
{
    public CommandResult Handle(ReadAllShopItemCommand command)
    {
        var items = _repository.GetAllShopItem(command.ShopListId);

        return new CommandResult
        {
            Success = true,
            Message = "Listas de compras encontradas",
            Data = items
        };
    }
}
