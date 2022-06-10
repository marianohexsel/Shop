namespace Shop.Domain.Commands;
public class CommandResult
{
    public bool Success { get; set; }
    public string Message { get; set; } = null!;
    public object Data { get; set; } = null!;
}
