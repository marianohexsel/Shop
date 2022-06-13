using Flunt.Validations;

namespace Shop.Domain.Commands;

public class UpdateShopItemCommand : Command
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public Guid IdShopList { get; set; }

    public override void Validate()
    {
        AddNotifications(new Contract<UpdateShopItemCommand>()
            .Requires()
            .IsNotNullOrEmpty(IdShopList.ToString(), "Id", "Escolha uma lista válida para atualizar.")
            .IsNotNullOrEmpty(Id.ToString(), "Id", "Escolha um item válido para atualizar.")
            .IsGreaterThan(Title, 1, "Title", "Título deve conter no mínimo 2 letras")
        );
    }
}