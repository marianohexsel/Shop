
using Shop.Domain.Commands;
using Shop.Domain.Entities;
using Shop.Domain.Handlers.Contracts;

namespace Shop.Domain.Handlers;

public partial class ShopHandler : ShopHandlerBase, IHandler<CreateShopListCommand>
{
    public CommandResult Handle(CreateShopListCommand command)
    {
        command.Validate();
        if (command.IsValid is false)
            return new CommandResult
            {
                Success = false,
                Message = "Ops, parece que sua tarefa está errada!",
                Data = command.Notifications
            };

        var item = new ShopList(command);

        // Salva no banco
        _repository.Create(item);

        return new CommandResult
        {
            Success = true,
            Message = "Tarefa salva",
            Data = item
        };
    }
}
