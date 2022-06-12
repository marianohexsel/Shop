
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

        var item = _repository.GetAllShopList().Where(x => x.Id == command.Id).FirstOrDefault();

        if (item is null)
            return new CommandResult
            {
                Success = false,
                Message = "Ops, lista não encontrada!",
                Data = command.Notifications
            };

        item.UpdateTitle(command.Title);
        // Salva no banco
        _repository.Update(item);

        return new CommandResult
        {
            Success = true,
            Message = "Tarefa salva",
            Data = item
        };
    }
}
