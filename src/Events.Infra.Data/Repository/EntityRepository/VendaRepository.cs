using Events.Domain.Interfaces.EntityRepositorys;
using Events.Domain.Models;
using Events.Infra.Data.Context;

namespace Events.Infra.Data.Repository.EntityRepository
{
    public class VendaRepository : Repository<Venda>, IVendaRepository
    {
        public VendaRepository(SQLSContext sqlsContext) : base(sqlsContext)
        {
        }
    }
}
