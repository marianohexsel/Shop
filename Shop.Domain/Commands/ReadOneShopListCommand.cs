using Flunt.Validations;

namespace Shop.Domain.Commands;

public class ReadOneShopListCommand : Command
{
    public Guid Id { get; set; }

    public override void Validate()
    {
        AddNotifications(new Contract<UpdateShopListCommand>()
            .Requires()
            .IsNotNullOrEmpty(Id.ToString(), "Id", "Escolha uma lista válida")
        );
    }
}