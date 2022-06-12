using Flunt.Validations;
using Shop.Domain.Commands;

namespace Shop.Domain.Entities;

public class ShopItem : Entity
{
    public ShopItem(CreateShopItemCommand command)
    {
        UpdateShopListId(command.ShopListId);
        UpdateTitle(command.Title);
        UpdateQuantity(command.Quantity);
    }

    public Guid ShopListId  { get; private set; }
    public string Title { get; private set; } = string.Empty;
    public int Quantity { get; private set; }
    public bool Done { get; private set; } = false;
    public void UpdateTitle(string title)
    {
        Title = title;
    }
    public void UpdateQuantity(int quantity)
    {
        Quantity = quantity;
    }
    public void MarkAsDone()
    {
        Done = true;
    }
    public void MarkAsUndone()
    {
        Done = false;
    }
    private void UpdateShopListId(Guid shopListId)
    {
        ShopListId = shopListId;
    }
}