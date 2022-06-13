using Flunt.Validations;

namespace Shop.Domain.Commands;

public class DeleteShopItemCommand : Command
{
    public Guid Id { get; set; }

    public override void Validate()
    {
        AddNotifications(new Contract<CreateShopItemCommand>()
            .Requires()
            .IsNotNullOrEmpty(Id.ToString(), "Id", "Item precisa um Id válido.")
        );
    }
}