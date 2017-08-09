using Events.Domain.Models;
using Events.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.Infra.Data.Mappings
{
    public class Venda_ProdutoMap : EntityTypeConfiguration<Venda_Produto>
    {
        public override void Map(EntityTypeBuilder<Venda_Produto> venda_produto)
        {

            venda_produto.HasKey(vp => vp.Id);

            venda_produto.HasOne(vp => vp.Venda)
                .WithMany(v => v.Venda_Produtos)
                .HasForeignKey(vp => vp.Id_venda);

            venda_produto.HasOne(vp => vp.Produto)
                .WithMany(p => p.Venda_Produtos)
                .HasForeignKey(vp => vp.Id_produto);
        }
    }
}
