using Events.Domain.Core.Commands;

namespace Events.Domain.Core.UoW
{
    public interface IUnitOfWork
    {
        CommandResponse Commit();
    }
}
