﻿using Events.Domain.Core.Models;
using Events.Domain.Models;
using Events.Infra.Data.Extensions;
using Events.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Events.Infra.Data.Context
{
    public class SQLSContext : DbContext
    {
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Conta_Funcionario> Conta_Funcionarios { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Ficha> Fichas { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Pagamento_Ficha> Pagamento_Fichas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Venda_Produto> Venda_Produtos { get; set; }
        public DbSet<Cor> Cores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new ContaMap());
            modelBuilder.AddConfiguration(new Conta_FuncionarioMap());
            modelBuilder.AddConfiguration(new ContatoMap());
            modelBuilder.AddConfiguration(new ContratoMap());
            modelBuilder.AddConfiguration(new EnderecoMap());
            modelBuilder.AddConfiguration(new EventoMap());
            modelBuilder.AddConfiguration(new FichaMap());
            modelBuilder.AddConfiguration(new MovimentacaoMap());
            modelBuilder.AddConfiguration(new PagamentoMap());
            modelBuilder.AddConfiguration(new Pagamento_FichaMap());
            modelBuilder.AddConfiguration(new ProdutoMap());
            modelBuilder.AddConfiguration(new VendaMap());
            modelBuilder.AddConfiguration(new Venda_ProdutoMap());
            modelBuilder.AddConfiguration(new CorMap());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var criados = ChangeTracker.Entries().Where(e => e.Entity is Entity && e.State == EntityState.Added);
            var atualizados = ChangeTracker.Entries().Where(e => e.Entity is Entity && e.State == EntityState.Added);
            var deletados = ChangeTracker.Entries().Where(e => e.Entity is Entity && e.State == EntityState.Added);

            if (criados.Any()) CriaEntidades(criados);
            if (atualizados.Any()) AtualizaEntidades(atualizados);
            if (deletados.Any()) DeletaEntidades(deletados);

            return base.SaveChanges();
        }

        private void AtualizaEntidades(IEnumerable<EntityEntry> atualizados)
        {
            foreach (var entity in atualizados)
            {
                var entityAtualizada = (Entity)entity.Entity;
                entityAtualizada.AtualizadoEm = DateTime.Now;
            }
        }

        private void CriaEntidades(IEnumerable<EntityEntry> criados)
        {
            foreach (var entity in criados)
            {
                var entityCriada = (Entity)entity.Entity;
                entityCriada.CriadoEm = DateTime.Now;
            }
        }

        private void DeletaEntidades(IEnumerable<EntityEntry> deletados)
        {
            foreach (var entity in deletados)
            {
                entity.State = EntityState.Modified;
                var entityCriada = (Entity)entity.Entity;
                entityCriada.DeletadoEm = DateTime.Now;
                entityCriada.Deletado = true;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
