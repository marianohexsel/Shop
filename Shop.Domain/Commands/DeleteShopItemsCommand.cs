using Flunt.Validations;

namespace Shop.Domain.Commands;

public class DeleteShopItemsCommand : Command
{
    public List<Guid> Ids { get; set; } = new();

    public override void Validate()
    {
        foreach (var id in Ids)
        {
            AddNotifications(new Contract<CreateShopItemCommand>()
            .Requires()
            .IsNotNullOrEmpty(id.ToString(), "Id", "Id informado é inválido.")
            );
        }
    }
}