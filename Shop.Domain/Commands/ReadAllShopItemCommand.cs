using Flunt.Validations;

namespace Shop.Domain.Commands;

public class ReadAllShopItemCommand : Command
{

    public Guid ShopListId  { get; set; }

    public override void Validate()
    {
        AddNotifications(new Contract<ReadAllShopItemCommand>()
            .Requires()
            .IsNotNullOrEmpty(ShopListId.ToString(), "Id", "Escolha uma lista válida")
        );
    }
}