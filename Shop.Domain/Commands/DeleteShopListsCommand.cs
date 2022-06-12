using Flunt.Validations;

namespace Shop.Domain.Commands;

public class DeleteShopListsCommand : Command
{
    public List<Guid> Ids { get; set; }

    public override void Validate()
    {
        foreach (var id in Ids)
        {
            AddNotifications(new Contract<DeleteShopListCommand>()
               .Requires()
               .IsNotNullOrEmpty(id.ToString(), "Id", "Id informado é inválido.")
           );
        }
    }
}