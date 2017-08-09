using Events.Domain.Core.Commands;
using Events.Domain.Core.Events;

namespace Events.Domain.Core.Bus
{
    public interface IBus
    {
        void RaizeEvent<T>(T theEvent) where T : Event;

        void SendComaand<T>(T theCommand) where T : Command;
    }
}
