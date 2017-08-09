using Events.Domain.Models;
using Events.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.Infra.Data.Mappings
{
    public class ContratoMap : EntityTypeConfiguration<Contrato>
    {
        public override void Map(EntityTypeBuilder<Contrato> contrato)
        {
            contrato.HasKey(c => c.Id);

            contrato.HasOne(c => c.Loja)
                .WithMany(cc => cc.Loja_Contratos)
                .HasForeignKey(c => c.Id_loja)
                .IsRequired();

            contrato.HasOne(c => c.Organizador)
                .WithMany(cc => cc.Organizador_Contratos)
                .HasForeignKey(c => c.Id_organizador)
                .IsRequired();

            contrato.HasOne(c => c.Evento)
                .WithMany(e => e.Contratos)
                .HasForeignKey(c => c.Id_evento)
                .IsRequired();

        }
    }
}
