using Events.Domain.Models;
using Events.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.Infra.Data.Mappings
{
    public class CorMap : EntityTypeConfiguration<Cor>
    {
        public override void Map(EntityTypeBuilder<Cor> cor)
        {
            cor.HasMany(c => c.Produtos)
                .WithOne(p => p.Cor)
                .HasForeignKey(c => c.Id_Cor);
        }
    }
}
