using Events.Domain.Interfaces.EntityRepositorys;
using Events.Domain.Models;
using Events.Infra.Data.Context;

namespace Events.Infra.Data.Repository.EntityRepository
{
    public class CorRepository : Repository<Cor>, ICorRepository
    {
        public CorRepository(SQLSContext sqlsContext) : base(sqlsContext)
        {
        }
    }
}
