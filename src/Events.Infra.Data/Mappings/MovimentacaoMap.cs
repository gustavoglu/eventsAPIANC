using Events.Domain.Models;
using Events.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.Infra.Data.Mappings
{
    public class MovimentacaoMap : EntityTypeConfiguration<Movimentacao>
    {
        public override void Map(EntityTypeBuilder<Movimentacao> movimentacao)
        {
            movimentacao.HasOne(m => m.Pagamento)
                .WithMany(p => p.Movimentacoes)
                .HasForeignKey(m => m.Id_Pagamento)
                .IsRequired(false);

            movimentacao.HasOne(m => m.Ficha)
               .WithMany(f => f.Movimentacoes)
               .HasForeignKey(m => m.Id_ficha)
               .IsRequired();
        }
    }
}
