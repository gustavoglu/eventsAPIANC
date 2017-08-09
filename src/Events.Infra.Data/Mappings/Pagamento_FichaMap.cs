﻿using Events.Domain.Models;
using Events.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.Infra.Data.Mappings
{
    public class Pagamento_FichaMap : EntityTypeConfiguration<Pagamento_Ficha>
    {
        public override void Map(EntityTypeBuilder<Pagamento_Ficha> pagamento_ficha)
        {
            pagamento_ficha.HasKey(pf => pf.Id);

            pagamento_ficha.HasOne(pf => pf.Ficha)
                .WithMany(f => f.Pagamento_Fichas)
                .HasForeignKey(pf => pf.Id_ficha);

        }
    }
}
