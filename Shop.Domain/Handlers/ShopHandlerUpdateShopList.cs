
using Shop.Domain.Commands;
using Shop.Domain.Entities;
using Shop.Domain.Handlers.Contracts;

namespace Shop.Domain.Handlers;

public partial class ShopHandler : ShopHandlerBase, IHandler<CreateShopListCommand>
{
    public CommandResult Handle(UpdateShopListCommand command)
    {
        command.Validate();
        if (command.IsValid is false)
            return new CommandResult
            {
                Success = false,
                Message = "Ops, parece que sua tarefa está errada!",
                Data = command.Notifications
            };

        var item = _repository.GetShopListById(command.Id);

        if (item is null)
            return new CommandResult
            {
                Success = false,
                Message = "Ops, lista não encontrada!",
                Data = command.Notifications
            };

        item.UpdateTitle(command.Title);
        _repository.Update(item);

        return new CommandResult
        {
            Success = true,
            Message = "Tarefa atualizada",
            Data = item
        };
    }
}
