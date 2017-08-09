using Events.Domain.Interfaces.EntityRepositorys;
using Events.Domain.Models;
using Events.Infra.Data.Context;

namespace Events.Infra.Data.Repository.EntityRepository
{
    public class Conta_FuncionarioRepository : Repository<Conta_Funcionario>, IConta_FuncionarioRepository
    {
        public Conta_FuncionarioRepository(SQLSContext sqlsContext) : base(sqlsContext)
        {
        }
    }
}
