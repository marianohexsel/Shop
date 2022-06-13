using Flunt.Validations;

namespace Shop.Domain.Commands;

public class UpdateShopListCommand : Command
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;

    public override void Validate()
    {
        AddNotifications(new Contract<UpdateShopListCommand>()
            .Requires()
            .IsNotNullOrEmpty(Id.ToString(), "Id", "Escolha um item válido para excluir.")
            .IsGreaterThan(Title, 1, "Title", "Título deve conter no mínimo 2 letras")
        );
    }
}