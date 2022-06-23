
using Shop.Domain.Commands;
using Shop.Domain.Entities;
using Shop.Domain.Handlers.Contracts;

namespace Shop.Domain.Handlers;

public partial class ShopHandler : ShopHandlerBase, IHandler<CreateShopListCommand>
{
    public CommandResult Handle(ReadAllShopItemCommand command)
    {
        var items = _repository.GetAllShopItem(command.ShopListId);

        if (items is null)
        {
            return new CommandResult
            {
                Success = false,
                Message = "Lista de compras não encontrada",
                Data = null
            };
        }

        return new CommandResult
        {
            Success = true,
            Message = "Lista de compra encontrada",
            Data = items
        };
    }
}
