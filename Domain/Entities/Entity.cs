using Flunt.Notifications;

namespace Shop.Domain.Entities;

public abstract class Entity : Notifiable<Notification>, IEquatable<Entity>
{
    public Entity()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; private set; }

    public bool Equals(Entity? other)
    {
        return this.Id == other?.Id;
    }
}