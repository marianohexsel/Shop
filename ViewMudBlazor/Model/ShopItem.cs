namespace Shop.View.Model;

public class ShopItem
{
    public Guid ShopListId  { get; private set; }
    public string Title { get; private set; } = string.Empty;
    public int Quantity { get; private set; }
    public bool Done { get; private set; } = false;
}