using Events.Domain.Interfaces.EntityRepositorys;
using Events.Domain.Models;
using Events.Infra.Data.Context;

namespace Events.Infra.Data.Repository.EntityRepository
{
    public class Pagamento_FichaRepository : Repository<Pagamento_Ficha>, IPagamento_FichaRepository
    {
        public Pagamento_FichaRepository(SQLSContext sqlsContext) : base(sqlsContext)
        {
        }
    }
}
