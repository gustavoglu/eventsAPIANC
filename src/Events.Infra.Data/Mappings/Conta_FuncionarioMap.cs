using Events.Domain.Models;
using Events.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.Infra.Data.Mappings
{
    public class Conta_FuncionarioMap : EntityTypeConfiguration<Conta_Funcionario>
    {
        public override void Map(EntityTypeBuilder<Conta_Funcionario> conta_funcionario)
        {
            conta_funcionario.HasKey(cf => cf.Id);

            conta_funcionario.HasOne(cf => cf.Funcionario)
                .WithMany(f => f.Conta_Funcionarios)
                .HasForeignKey(cf => cf.Id_funcionario)
                .IsRequired();

            conta_funcionario.HasOne(cf => cf.Conta)
                .WithMany(f => f.Conta_Lojas)
                .HasForeignKey(cf => cf.Id_conta)
                .IsRequired();

        }
    }
}
