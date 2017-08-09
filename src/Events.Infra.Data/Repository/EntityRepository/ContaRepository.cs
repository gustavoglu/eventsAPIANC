using Events.Domain.Interfaces.EntityRepositorys;
using Events.Domain.Models;
using Events.Infra.Data.Context;

namespace Events.Infra.Data.Repository.EntityRepository
{
    public class ContaRepository : Repository<Conta>, IContaRepository
    {
        public ContaRepository(SQLSContext sqlsContext) : base(sqlsContext)
        {
        }
    }
}
