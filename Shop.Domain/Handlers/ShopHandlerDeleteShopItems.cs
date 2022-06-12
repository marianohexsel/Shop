
using Shop.Domain.Commands;
using Shop.Domain.Entities;
using Shop.Domain.Handlers.Contracts;

namespace Shop.Domain.Handlers;

public partial class ShopHandler : ShopHandlerBase, IHandler<CreateShopItemCommand>
{
    public CommandResult Handle(DeleteShopItemsCommand command)
    {
        List<CommandResult> results = new();
        foreach (var id in command.Ids)
        {
            var item = _repository.GetShopItemById(id);

            if (item is null)
            {
                results.Add(new CommandResult
                {
                    Success = false,
                    Message = $"Item não encontrado, Id:{id}",
                    Data = command.Notifications
                });
            }
            else
                _repository.Delete(item);
        }

        if (results.Count == 0)
            return new CommandResult
            {
                Success = true,
                Message = "Itens excluídos com sucesso",
                Data = command.Notifications
            };
        else
        {
            return new CommandResult
            {
                Success = false,
                Message = $"Itens não encontrados: {results}",
                Data = command.Notifications
            };
        }
    }
}
