using Events.Domain.Interfaces.EntityRepositorys;
using Events.Domain.Models;
using Events.Infra.Data.Context;

namespace Events.Infra.Data.Repository.EntityRepository
{
    public class EventoRepository : Repository<Evento>, IEventoRepository
    {
        public EventoRepository(SQLSContext sqlsContext) : base(sqlsContext)
        {
        }
    }
}
