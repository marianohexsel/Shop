
using Shop.Domain.Commands;
using Shop.Domain.Entities;
using Shop.Domain.Handlers.Contracts;

namespace Shop.Domain.Handlers;

public partial class ShopHandler : ShopHandlerBase, IHandler<CreateShopItemCommand>
{
    public CommandResult Handle(CreateShopItemCommand command)
    {
        var item = new ShopItem(command);
        if (item.IsValid)
            return new GenericCommandResult{
                Success = false, 
                Message = "Ops, parece que sua tarefa está errada!", 
                Data = item.Notifications
            };

        // Salva no banco
        _repository.Create(item);

        return new GenericCommandResult{
            Success = true, 
            Message = "Tarefa salva", 
            Data = item
        };
    }
}
