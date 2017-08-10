using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Events.Infra.Data.Context;
using Events.Domain.Models.Enums;

namespace Events.Infra.Data.Migrations
{
    [DbContext(typeof(SQLSContext))]
    partial class SQLSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Events.Domain.Models.Conta", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<DateTime>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("CriadoPor");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<bool>("Deletado");

                    b.Property<DateTime>("DeletadoEm");

                    b.Property<string>("DeletadoPor");

                    b.Property<string>("Documento");

                    b.Property<int>("DocumentoTipo");

                    b.Property<Guid>("Id_Conta_Principal");

                    b.Property<string>("Nome");

                    b.Property<string>("RazaoSocial");

                    b.Property<string>("Sobrenome");

                    b.Property<int>("Tipo");

                    b.HasKey("Id");

                    b.HasIndex("Id_Conta_Principal")
                        .IsUnique();

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("Events.Domain.Models.Conta_Funcionario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Aprovador");

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("CriadoPor");

                    b.Property<bool>("Deletado");

                    b.Property<DateTime>("DeletadoEm");

                    b.Property<string>("DeletadoPor");

                    b.Property<Guid>("Id_conta");

                    b.Property<Guid>("Id_funcionario");

                    b.Property<bool>("Permanente");

                    b.Property<DateTime>("Vencimento");

                    b.HasKey("Id");

                    b.HasIndex("Id_funcionario");

                    b.ToTable("Conta_Funcionarios");
                });

            modelBuilder.Entity("Events.Domain.Models.Contato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("CriadoPor");

                    b.Property<bool>("Deletado");

                    b.Property<DateTime>("DeletadoEm");

                    b.Property<string>("DeletadoPor");

                    b.Property<string>("Email");

                    b.Property<string>("EmailAdicional");

                    b.Property<string>("Telefone");

                    b.Property<string>("Telefone2");

                    b.HasKey("Id");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("Events.Domain.Models.Contrato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Aprovado");

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("CriadoPor");

                    b.Property<DateTime>("DataAprovacao");

                    b.Property<bool>("Deletado");

                    b.Property<DateTime>("DeletadoEm");

                    b.Property<string>("DeletadoPor");

                    b.Property<string>("Descricao");

                    b.Property<Guid>("Id_evento");

                    b.Property<Guid>("Id_loja");

                    b.Property<Guid>("Id_organizador");

                    b.Property<DateTime>("Vencimento");

                    b.HasKey("Id");

                    b.HasIndex("Id_evento");

                    b.HasIndex("Id_loja");

                    b.HasIndex("Id_organizador");

                    b.ToTable("Contratos");
                });

            modelBuilder.Entity("Events.Domain.Models.Cor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<string>("CorFromHex");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("CriadoPor");

                    b.Property<bool>("Deletado");

                    b.Property<DateTime>("DeletadoEm");

                    b.Property<string>("DeletadoPor");

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("Cores");
                });

            modelBuilder.Entity("Events.Domain.Models.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<string>("Bairro");

                    b.Property<string>("Cidade");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("CriadoPor");

                    b.Property<bool>("Deletado");

                    b.Property<DateTime>("DeletadoEm");

                    b.Property<string>("DeletadoPor");

                    b.Property<string>("Estado");

                    b.Property<string>("Pais");

                    b.Property<string>("Rua");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Events.Domain.Models.Evento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<bool>("Cancelado");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("CriadoPor");

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<bool>("Deletado");

                    b.Property<DateTime>("DeletadoEm");

                    b.Property<string>("DeletadoPor");

                    b.Property<string>("Descricao");

                    b.Property<Guid>("Id_organizador");

                    b.HasKey("Id");

                    b.HasIndex("Id_organizador");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("Events.Domain.Models.Ficha", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("CriadoPor");

                    b.Property<bool>("Deletado");

                    b.Property<DateTime>("DeletadoEm");

                    b.Property<string>("DeletadoPor");

                    b.Property<string>("NomeCliente");

                    b.Property<double>("Saldo");

                    b.HasKey("Id");

                    b.ToTable("Fichas");
                });

            modelBuilder.Entity("Events.Domain.Models.Movimentacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("CriadoPor");

                    b.Property<bool>("Deletado");

                    b.Property<DateTime>("DeletadoEm");

                    b.Property<string>("DeletadoPor");

                    b.Property<Guid?>("Id_Pagamento");

                    b.Property<Guid>("Id_ficha");

                    b.Property<int>("MovimentacaoTipo");

                    b.Property<string>("Observacao");

                    b.Property<double>("SaldoAnterior");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("Id_Pagamento");

                    b.HasIndex("Id_ficha");

                    b.ToTable("Movimentacoes");
                });

            modelBuilder.Entity("Events.Domain.Models.Pagamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<bool>("Cancelado");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("CriadoPor");

                    b.Property<bool>("Deletado");

                    b.Property<DateTime>("DeletadoEm");

                    b.Property<string>("DeletadoPor");

                    b.Property<Guid>("Id_venda");

                    b.Property<double>("Total");

                    b.HasKey("Id");

                    b.HasIndex("Id_venda");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("Events.Domain.Models.Pagamento_Ficha", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("CriadoPor");

                    b.Property<bool>("Deletado");

                    b.Property<DateTime>("DeletadoEm");

                    b.Property<string>("DeletadoPor");

                    b.Property<Guid>("Id_ficha");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("Id_ficha");

                    b.ToTable("Pagamento_Fichas");
                });

            modelBuilder.Entity("Events.Domain.Models.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("CriadoPor");

                    b.Property<bool>("Deletado");

                    b.Property<DateTime>("DeletadoEm");

                    b.Property<string>("DeletadoPor");

                    b.Property<string>("Descricao");

                    b.Property<Guid>("Id_Cor");

                    b.Property<Guid>("Id_loja");

                    b.Property<double>("Preco");

                    b.Property<int>("Tipo");

                    b.HasKey("Id");

                    b.HasIndex("Id_Cor");

                    b.HasIndex("Id_loja");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Events.Domain.Models.Venda", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<bool>("Cancelada");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("CriadoPor");

                    b.Property<DateTime>("Data");

                    b.Property<bool>("Deletado");

                    b.Property<DateTime>("DeletadoEm");

                    b.Property<string>("DeletadoPor");

                    b.Property<Guid>("Id_Evento");

                    b.Property<Guid>("Id_loja");

                    b.Property<double>("Total");

                    b.HasKey("Id");

                    b.HasIndex("Id_Evento");

                    b.HasIndex("Id_loja");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("Events.Domain.Models.Venda_Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("CriadoPor");

                    b.Property<bool>("Deletado");

                    b.Property<DateTime>("DeletadoEm");

                    b.Property<string>("DeletadoPor");

                    b.Property<Guid>("Id_produto");

                    b.Property<Guid>("Id_venda");

                    b.Property<int>("Quantidade");

                    b.Property<double>("ValorTotal");

                    b.HasKey("Id");

                    b.HasIndex("Id_produto");

                    b.HasIndex("Id_venda");

                    b.ToTable("Venda_Produtos");
                });

            modelBuilder.Entity("Events.Domain.Models.Conta", b =>
                {
                    b.HasOne("Events.Domain.Models.Contato", "Contato")
                        .WithOne("Conta")
                        .HasForeignKey("Events.Domain.Models.Conta", "Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Events.Domain.Models.Endereco", "Endereco")
                        .WithOne("Conta")
                        .HasForeignKey("Events.Domain.Models.Conta", "Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Events.Domain.Models.Conta_Funcionario", "Conta_Principal")
                        .WithOne("Conta")
                        .HasForeignKey("Events.Domain.Models.Conta", "Id_Conta_Principal")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Events.Domain.Models.Conta_Funcionario", b =>
                {
                    b.HasOne("Events.Domain.Models.Conta", "Funcionario")
                        .WithMany("Conta_Funcionarios")
                        .HasForeignKey("Id_funcionario");
                });

            modelBuilder.Entity("Events.Domain.Models.Contrato", b =>
                {
                    b.HasOne("Events.Domain.Models.Evento", "Evento")
                        .WithMany("Contratos")
                        .HasForeignKey("Id_evento")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Events.Domain.Models.Conta", "Loja")
                        .WithMany("Loja_Contratos")
                        .HasForeignKey("Id_loja");

                    b.HasOne("Events.Domain.Models.Conta", "Organizador")
                        .WithMany("Organizador_Contratos")
                        .HasForeignKey("Id_organizador");
                });

            modelBuilder.Entity("Events.Domain.Models.Evento", b =>
                {
                    b.HasOne("Events.Domain.Models.Conta", "Organizador")
                        .WithMany("Eventos")
                        .HasForeignKey("Id_organizador")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Events.Domain.Models.Movimentacao", b =>
                {
                    b.HasOne("Events.Domain.Models.Pagamento", "Pagamento")
                        .WithMany("Movimentacoes")
                        .HasForeignKey("Id_Pagamento");

                    b.HasOne("Events.Domain.Models.Ficha", "Ficha")
                        .WithMany("Movimentacoes")
                        .HasForeignKey("Id_ficha")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Events.Domain.Models.Pagamento", b =>
                {
                    b.HasOne("Events.Domain.Models.Venda", "Venda")
                        .WithMany("Pagamentos")
                        .HasForeignKey("Id_venda")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Events.Domain.Models.Pagamento_Ficha", b =>
                {
                    b.HasOne("Events.Domain.Models.Ficha", "Ficha")
                        .WithMany("Pagamento_Fichas")
                        .HasForeignKey("Id_ficha")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Events.Domain.Models.Produto", b =>
                {
                    b.HasOne("Events.Domain.Models.Cor", "Cor")
                        .WithMany("Produtos")
                        .HasForeignKey("Id_Cor")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Events.Domain.Models.Conta", "Loja")
                        .WithMany("Produtos")
                        .HasForeignKey("Id_loja")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Events.Domain.Models.Venda", b =>
                {
                    b.HasOne("Events.Domain.Models.Evento", "Evento")
                        .WithMany("Vendas")
                        .HasForeignKey("Id_Evento")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Events.Domain.Models.Conta", "Conta")
                        .WithMany("Vendas")
                        .HasForeignKey("Id_loja");
                });

            modelBuilder.Entity("Events.Domain.Models.Venda_Produto", b =>
                {
                    b.HasOne("Events.Domain.Models.Produto", "Produto")
                        .WithMany("Venda_Produtos")
                        .HasForeignKey("Id_produto")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Events.Domain.Models.Venda", "Venda")
                        .WithMany("Venda_Produtos")
                        .HasForeignKey("Id_venda");
                });
        }
    }
}
