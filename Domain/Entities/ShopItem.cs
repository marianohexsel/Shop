using Flunt.Validations;
using Shop.Domain.Commands;

namespace Shop.Domain.Entities;

public class ShopItem : Entity
{
    public ShopItem(CreateShopItemCommand command)
    {
        this.User = command.User;
        UpdateTitle(command.Title);
        UpdateDescription(command.Description);
        UpdateQuantity(command.Quantity);
        AddNotifications( new Contract<ShopItem>()
            .Requires()
            .IsNotNullOrEmpty(command.User, "User", "User não pode ser vazio")
        );
    }

    public string Title { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public int Quantity { get; private set; }
    public string User { get; private set; } = string.Empty;
    public bool Done { get; private set; } = false;

    public void UpdateTitle(string title)
    {
        this.Title = title;
        AddNotifications( new Contract<ShopItem>()
            .Requires()
            .IsNotNullOrEmpty(title, "Title", "Título não pode ser vazio")
        );
    }
    public void UpdateDescription(string description)
    {
        this.Description = description ?? string.Empty;
    }
    public void UpdateQuantity(int quantity)
    {
        this.Quantity = quantity;
        AddNotifications( new Contract<ShopItem>()
            .Requires()
            .IsGreaterThan(quantity, 0, "Quantity", "Quantidade não pode ser zero")
        );

    }
    public void MarkAsDone()
    {
        this.Done = true;
    }
    public void MarkAsUndone()
    {
        this.Done = false;
    }
}