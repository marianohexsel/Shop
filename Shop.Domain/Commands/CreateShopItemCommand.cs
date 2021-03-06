using Flunt.Validations;

namespace Shop.Domain.Commands;

public class CreateShopItemCommand : Command
{
    public Guid ShopListId { get; set; }
    public string Title { get; set; } = null!;
    public int Quantity { get; set; }

    public override void Validate()
    {
        AddNotifications(new Contract<CreateShopItemCommand>()
            .Requires()
            .IsGreaterThan(Quantity, 0, "Quantity", "Quantidade não pode ser zero")
            .IsNotNullOrEmpty(Title, "Title", "Título não pode ser vazio")
            .IsGreaterThan(Title, 1, "Title", "Título deve conter no mínimo 2 letras")
        );

    }
}