
using Shop.Domain.Commands;

namespace Shop.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T : Command
    {
        CommandResult Handle(T command);
    }
}