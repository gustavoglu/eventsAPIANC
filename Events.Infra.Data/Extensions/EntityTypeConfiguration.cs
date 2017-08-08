using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.Infra.Data.Extensions
{
    public abstract class EntityTypeConfiguration<T> where T : class
    {
        public abstract void Map(EntityTypeBuilder<T> builder);
    }
}
