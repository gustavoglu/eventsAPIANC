using Events.Domain.Models;
using Events.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.Infra.Data.Mappings
{
    public class ContatoMap : EntityTypeConfiguration<Contato>
    {
        public override void Map(EntityTypeBuilder<Contato> contato)
        {
            contato.HasOne(c => c.Conta)
                .WithOne(cc => cc.Contato)
                .HasForeignKey<Conta>(c => c.Id);
        }
    }
}
