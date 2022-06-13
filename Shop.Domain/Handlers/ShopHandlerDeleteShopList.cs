
using Shop.Domain.Commands;
using Shop.Domain.Entities;
using Shop.Domain.Handlers.Contracts;

namespace Shop.Domain.Handlers;

public partial class ShopHandler : ShopHandlerBase, IHandler<CreateShopListCommand>
{
    public CommandResult Handle(DeleteShopListCommand command)
    {
        var item = _repository.GetAllShopList().Where(x => x.Id == command.Id).FirstOrDefault();

        if (item is null)
            return new CommandResult
            {
                Success = false,
                Message = "Ops, lista não encontrada!",
                Data = command.Notifications
            };

        // Salva no banco
        _repository.Delete(item);

        return new CommandResult
        {
            Success = true,
            Message = "Item excluido",
            Data = item
        };
    }
}
