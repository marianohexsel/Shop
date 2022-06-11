using Flunt.Notifications;

namespace Shop.Domain.Commands;
public abstract class Command : Notifiable<Notification>
{
    public abstract void Validate();
}
