using Flunt.Validations;

namespace Shop.Domain.Commands;

public class UpdateShopItemCommand : Command
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public int Quantity { get; set; }
    public bool Done { get; set; }
    public Guid ShopListId { get; set; }

    public override void Validate()
    {
        AddNotifications(new Contract<UpdateShopItemCommand>()
            .Requires()
            .IsNotNullOrEmpty(ShopListId.ToString(), "Id", "Escolha uma lista válida para atualizar.")
            .IsNotNullOrEmpty(Id.ToString(), "Id", "Escolha um item válido para atualizar.")
            .IsGreaterThan(Title, 1, "Title", "Título deve conter no mínimo 2 letras")
            .IsGreaterThan(Quantity, 1, "Quantity", "Deve ter no mínimo 1 item")
        );
    }
}