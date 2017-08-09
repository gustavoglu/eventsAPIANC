using Events.Domain.Models;
using Events.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.Infra.Data.Mappings
{
    public class EnderecoMap : EntityTypeConfiguration<Endereco>
    {
        public override void Map(EntityTypeBuilder<Endereco> endereco)
        {
            endereco.HasOne(e => e.Conta)
                .WithOne(c => c.Endereco)
                .HasForeignKey<Conta>(c => c.Id);
        }
    }
}
