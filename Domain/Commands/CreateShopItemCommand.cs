namespace Shop.Domain.Commands;

public class CreateShopItemCommand : Command
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int Quantity { get; set; }
    public string User { get; set; } = null!;

}