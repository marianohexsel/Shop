using Flunt.Validations;
using Shop.Domain.Commands;

namespace Shop.Domain.Entities;

public class ShopList : Entity
{
    public ShopList(CreateShopListCommand command)
    {
        UpdateTitle(command.Title);
    }

    public string Title { get; private set; } = string.Empty;
    
    public void UpdateTitle(string title)
    {
        Title = title;
    }
}