using Flunt.Validations;

namespace Shop.Domain.Commands;

public class DeleteShopListCommand : Command
{
    public Guid Id { get; set; }

    public override void Validate()
    {
        AddNotifications(new Contract<DeleteShopListCommand>()
            .Requires()
            .IsNotNullOrEmpty(Id.ToString(), "Id", "Escolha algum item válido para excluir.")
        );
    }
}