﻿using Events.Domain.Models;
using Events.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.Infra.Data.Mappings
{
    public class PagamentoMap : EntityTypeConfiguration<Pagamento>
    {
        public override void Map(EntityTypeBuilder<Pagamento> pagamento)
        {
            pagamento.HasKey(p => p.Id);

            pagamento.HasOne(p => p.Venda)
                .WithMany(v => v.Pagamentos)
                .HasForeignKey(p => p.Id_venda)
                .IsRequired();

        }
    }
}
