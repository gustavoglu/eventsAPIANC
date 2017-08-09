using Events.Domain.Interfaces.EntityRepositorys;
using Events.Domain.Models;
using Events.Infra.Data.Context;

namespace Events.Infra.Data.Repository.EntityRepository
{
    public class Venda_ProdutoRepository : Repository<Venda_Produto>, IVenda_ProdutoRepository
    {
        public Venda_ProdutoRepository(SQLSContext sqlsContext) : base(sqlsContext)
        {
        }
    }
}
