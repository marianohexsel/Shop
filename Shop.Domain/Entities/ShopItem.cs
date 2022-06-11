using Flunt.Validations;
using Shop.Domain.Commands;

namespace Shop.Domain.Entities;

public class ShopItem : Entity
{
    public ShopItem(CreateShopItemCommand command)
    {
        UpdateTitle(command.Title);
        UpdateDescription(command.Description);
        UpdateQuantity(command.Quantity);
        UpdateUser(command.User);
    }

    public string Title { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public int Quantity { get; private set; }
    public string User { get; private set; } = string.Empty;
    public bool Done { get; private set; } = false;

    public void UpdateTitle(string title)
    {
        this.Title = title;
    }
    public void UpdateDescription(string description)
    {
        this.Description = description ?? string.Empty;
    }
    public void UpdateQuantity(int quantity)
    {
        this.Quantity = quantity;
        
    }
    public void MarkAsDone()
    {
        this.Done = true;
    }
    public void MarkAsUndone()
    {
        this.Done = false;
    }

    private void UpdateUser(string user)
    {
        this.User = user;
    }
}