using Events.Domain.Interfaces.EntityRepositorys;
using Events.Domain.Models;
using Events.Infra.Data.Context;

namespace Events.Infra.Data.Repository.EntityRepository
{
    public class MovimentacaoRepository : Repository<Movimentacao>, IMovimentacaoRepository
    {
        public MovimentacaoRepository(SQLSContext sqlsContext) : base(sqlsContext)
        {
        }
    }
}
