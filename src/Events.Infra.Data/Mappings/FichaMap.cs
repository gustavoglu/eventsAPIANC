using Events.Domain.Models;
using Events.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.Infra.Data.Mappings
{
    public class FichaMap : EntityTypeConfiguration<Ficha>
    {
        public override void Map(EntityTypeBuilder<Ficha> ficha)
        {
            ficha.HasKey(f => f.Id);
        }
    }
}
