using Events.Domain.Models;
using Events.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.Infra.Data.Mappings
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public override void Map(EntityTypeBuilder<Produto> produto)
        {
            produto.HasOne(p => p.Loja)
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.Id_loja)
                .IsRequired();
        }
    }
}
