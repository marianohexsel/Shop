
using Shop.Domain.Commands;
using Shop.Domain.Entities;
using Shop.Domain.Handlers.Contracts;

namespace Shop.Domain.Handlers;

public partial class ShopHandler : ShopHandlerBase, IHandler<CreateShopListCommand>
{
    public CommandResult Handle(UpdateShopItemCommand command)
    {
        command.Validate();
        if (command.IsValid is false)
            return new CommandResult
            {
                Success = false,
                Message = "Ops, parece que seu item errado!",
                Data = command.Notifications
            };

        var item = _repository.GetAllShopItem(command.ShopListId).Where(x => x.Id == command.Id).FirstOrDefault();

        if (item is null)
            return new CommandResult
            {
                Success = false,
                Message = "Ops, item não encontrado!",
                Data = command.Notifications
            };

        item.UpdateTitle(command.Title);
        item.UpdateQuantity(command.Quantity);
        if (command.Done)
            item.MarkAsDone();
        else
            item.MarkAsUndone();

        _repository.Update(item);

        return new CommandResult
        {
            Success = true,
            Message = "Tarefa atualizada",
            Data = item
        };
    }
}
