using Flunt.Validations;

namespace Shop.Domain.Commands;

public class CreateShopListCommand : Command
{
    public string Title { get; set; } = null!;

    public override void Validate()
    {
        AddNotifications(new Contract<CreateShopItemCommand>()
            .Requires()
            .IsGreaterThan(Title, 1, "Title", "Título deve conter no mínimo 2 letras")
        );
        
    }
}