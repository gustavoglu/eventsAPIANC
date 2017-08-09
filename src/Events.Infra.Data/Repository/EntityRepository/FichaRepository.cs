using Events.Domain.Interfaces.EntityRepositorys;
using Events.Domain.Models;
using Events.Infra.Data.Context;

namespace Events.Infra.Data.Repository.EntityRepository
{
    public class FichaRepository : Repository<Ficha>, IFichaRepository
    {
        public FichaRepository(SQLSContext sqlsContext) : base(sqlsContext)
        {
        }
    }
}
