
using System.Text;
using Shop.Domain.Commands;
using Shop.Domain.Handlers.Contracts;

namespace Shop.Domain.Handlers;

public partial class ShopHandler : ShopHandlerBase, IHandler<CreateShopListCommand>
{
    public CommandResult Handle(DeleteShopListsCommand command)
    {

        StringBuilder sbNotFoundIds = new StringBuilder();
        foreach (var id in command.Ids)
        {
            var item = _repository.GetShopListById(id);

            if (item is null)
                sbNotFoundIds.AppendLine(id.ToString());
            else
                _repository.Delete(item);
        }

        if (sbNotFoundIds.ToString().Length > 0)
            return new CommandResult
            {
                Success = false,
                Message = $"Alguns Ids não foram encontrados para excluir: {sbNotFoundIds.ToString()}",
                Data = command.Notifications
            };
        else
            return new CommandResult
            {
                Success = true,
                Message = "Itens excluido",
                Data = command.Notifications
            };
    }
}
