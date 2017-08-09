using Events.Domain.Interfaces.EntityRepositorys;
using Events.Domain.Models;
using Events.Infra.Data.Context;

namespace Events.Infra.Data.Repository.EntityRepository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(SQLSContext sqlsContext) : base(sqlsContext)
        {
        }
    }
}
