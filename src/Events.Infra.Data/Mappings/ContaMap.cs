﻿using Events.Domain.Models;
using Events.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.Infra.Data.Mappings
{
    public class ContaMap : EntityTypeConfiguration<Conta>
    {
        public override void Map(EntityTypeBuilder<Conta> conta)
        {
            conta.HasKey(c => c.Id);

            conta.HasMany(c => c.Loja_Contratos)
                .WithOne(cc => cc.Loja)
                .HasForeignKey(cc => cc.Id_loja)
                .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);

            conta.HasMany(c => c.Organizador_Contratos)
                .WithOne(cc => cc.Organizador)
                .HasForeignKey(cc => cc.Id_organizador)
                .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);

            conta.HasMany(c => c.Vendas)
                .WithOne(v => v.Conta)
                .HasForeignKey(v => v.Id_loja)
                .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);
        }
    }
}
