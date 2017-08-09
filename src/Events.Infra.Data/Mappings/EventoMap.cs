﻿using Events.Domain.Models;
using Events.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.Infra.Data.Mappings
{
    public class EventoMap : EntityTypeConfiguration<Evento>
    {
        public override void Map(EntityTypeBuilder<Evento> evento)
        {
            evento.HasKey(e => e.Id);

            evento.HasOne(e => e.Organizador)
                .WithMany(o => o.Eventos)
                .HasForeignKey(e => e.Id_organizador)
                .IsRequired();

            evento.HasMany(e => e.Contratos)
                .WithOne(c => c.Evento)
                .HasForeignKey(c => c.Id_evento);

        }
    }
}
