
using Shop.Domain.Commands;
using Shop.Domain.Entities;
using Shop.Domain.Handlers.Contracts;

namespace Shop.Domain.Handlers;

public partial class ShopHandler : ShopHandlerBase, IHandler<CreateShopListCommand>
{
    public CommandResult Handle(ReadOneShopListCommand command)
    {
        var item = _repository.GetAllShopList().Where(x => x.Id == command.Id).FirstOrDefault();

        if (item is null)
            return new CommandResult
            {
                Success = false,
                Message = "Ops, lista não encontrada!",
                Data = command.Notifications
            };

        return new CommandResult
        {
            Success = true,
            Message = "Lista encontrada",
            Data = item
        };
    }
}
