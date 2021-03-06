namespace Shop.View.Commands;

abstract class  CommandResult
{
    public bool Success { get; set; }
    public string Message { get; set; } = null!;
}