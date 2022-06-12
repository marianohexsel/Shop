
using Shop.Domain.Commands;
using Shop.Domain.Entities;
using Shop.Domain.Handlers.Contracts;

namespace Shop.Domain.Handlers;

public partial class ShopHandler : ShopHandlerBase, IHandler<CreateShopItemCommand>
{
    public CommandResult Handle(DeleteShopItemCommand command)
    {
        var item = _repository.GetShopItemById(command.Id);

        if (item is null)
        {
            return new CommandResult
            {
                Success = false,
                Message = "Item não encontrado",
                Data = command.Notifications
            };
        }

        _repository.Delete(item);

        return new CommandResult
        {
            Success = true,
            Message = "Item excluído",
            Data = item
        };
    }
}
