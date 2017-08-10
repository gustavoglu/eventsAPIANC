using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Events.Infra.Data.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AtualizadoEm = table.Column<DateTime>(nullable: false),
                    AtualizadoPor = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    CriadoPor = table.Column<string>(nullable: true),
                    Deletado = table.Column<bool>(nullable: false),
                    DeletadoEm = table.Column<DateTime>(nullable: false),
                    DeletadoPor = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmailAdicional = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Telefone2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cores",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AtualizadoEm = table.Column<DateTime>(nullable: false),
                    AtualizadoPor = table.Column<string>(nullable: true),
                    CorFromHex = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    CriadoPor = table.Column<string>(nullable: true),
                    Deletado = table.Column<bool>(nullable: false),
                    DeletadoEm = table.Column<DateTime>(nullable: false),
                    DeletadoPor = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AtualizadoEm = table.Column<DateTime>(nullable: false),
                    AtualizadoPor = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    CriadoPor = table.Column<string>(nullable: true),
                    Deletado = table.Column<bool>(nullable: false),
                    DeletadoEm = table.Column<DateTime>(nullable: false),
                    DeletadoPor = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Pais = table.Column<string>(nullable: true),
                    Rua = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fichas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AtualizadoEm = table.Column<DateTime>(nullable: false),
                    AtualizadoPor = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    CriadoPor = table.Column<string>(nullable: true),
                    Deletado = table.Column<bool>(nullable: false),
                    DeletadoEm = table.Column<DateTime>(nullable: false),
                    DeletadoPor = table.Column<string>(nullable: true),
                    NomeCliente = table.Column<string>(nullable: true),
                    Saldo = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fichas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pagamento_Fichas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AtualizadoEm = table.Column<DateTime>(nullable: false),
                    AtualizadoPor = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    CriadoPor = table.Column<string>(nullable: true),
                    Deletado = table.Column<bool>(nullable: false),
                    DeletadoEm = table.Column<DateTime>(nullable: false),
                    DeletadoPor = table.Column<string>(nullable: true),
                    Id_ficha = table.Column<Guid>(nullable: false),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamento_Fichas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagamento_Fichas_Fichas_Id_ficha",
                        column: x => x.Id_ficha,
                        principalTable: "Fichas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Conta_Funcionarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Aprovador = table.Column<bool>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    AtualizadoEm = table.Column<DateTime>(nullable: false),
                    AtualizadoPor = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    CriadoPor = table.Column<string>(nullable: true),
                    Deletado = table.Column<bool>(nullable: false),
                    DeletadoEm = table.Column<DateTime>(nullable: false),
                    DeletadoPor = table.Column<string>(nullable: true),
                    Id_conta = table.Column<Guid>(nullable: false),
                    Id_funcionario = table.Column<Guid>(nullable: false),
                    Permanente = table.Column<bool>(nullable: false),
                    Vencimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conta_Funcionarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AtualizadoEm = table.Column<DateTime>(nullable: false),
                    AtualizadoPor = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Deletado = table.Column<bool>(nullable: false),
                    DeletadoEm = table.Column<DateTime>(nullable: false),
                    DeletadoPor = table.Column<string>(nullable: true),
                    Documento = table.Column<string>(nullable: true),
                    DocumentoTipo = table.Column<int>(nullable: false),
                    Id_Conta_Principal = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    RazaoSocial = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contas_Contatos_Id",
                        column: x => x.Id,
                        principalTable: "Contatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contas_Enderecos_Id",
                        column: x => x.Id,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contas_Conta_Funcionarios_Id_Conta_Principal",
                        column: x => x.Id_Conta_Principal,
                        principalTable: "Conta_Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AtualizadoEm = table.Column<DateTime>(nullable: false),
                    AtualizadoPor = table.Column<string>(nullable: true),
                    Cancelado = table.Column<bool>(nullable: false),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataFim = table.Column<DateTime>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    Deletado = table.Column<bool>(nullable: false),
                    DeletadoEm = table.Column<DateTime>(nullable: false),
                    DeletadoPor = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Id_organizador = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Eventos_Contas_Id_organizador",
                        column: x => x.Id_organizador,
                        principalTable: "Contas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AtualizadoEm = table.Column<DateTime>(nullable: false),
                    AtualizadoPor = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    CriadoPor = table.Column<string>(nullable: true),
                    Deletado = table.Column<bool>(nullable: false),
                    DeletadoEm = table.Column<DateTime>(nullable: false),
                    DeletadoPor = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Id_Cor = table.Column<Guid>(nullable: false),
                    Id_loja = table.Column<Guid>(nullable: false),
                    Preco = table.Column<double>(nullable: false),
                    Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Cores_Id_Cor",
                        column: x => x.Id_Cor,
                        principalTable: "Cores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produtos_Contas_Id_loja",
                        column: x => x.Id_loja,
                        principalTable: "Contas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contratos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Aprovado = table.Column<bool>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    AtualizadoEm = table.Column<DateTime>(nullable: false),
                    AtualizadoPor = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataAprovacao = table.Column<DateTime>(nullable: false),
                    Deletado = table.Column<bool>(nullable: false),
                    DeletadoEm = table.Column<DateTime>(nullable: false),
                    DeletadoPor = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Id_evento = table.Column<Guid>(nullable: false),
                    Id_loja = table.Column<Guid>(nullable: false),
                    Id_organizador = table.Column<Guid>(nullable: false),
                    Vencimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contratos_Eventos_Id_evento",
                        column: x => x.Id_evento,
                        principalTable: "Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contratos_Contas_Id_loja",
                        column: x => x.Id_loja,
                        principalTable: "Contas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contratos_Contas_Id_organizador",
                        column: x => x.Id_organizador,
                        principalTable: "Contas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AtualizadoEm = table.Column<DateTime>(nullable: false),
                    AtualizadoPor = table.Column<string>(nullable: true),
                    Cancelada = table.Column<bool>(nullable: false),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    CriadoPor = table.Column<string>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    Deletado = table.Column<bool>(nullable: false),
                    DeletadoEm = table.Column<DateTime>(nullable: false),
                    DeletadoPor = table.Column<string>(nullable: true),
                    Id_Evento = table.Column<Guid>(nullable: false),
                    Id_loja = table.Column<Guid>(nullable: false),
                    Total = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendas_Eventos_Id_Evento",
                        column: x => x.Id_Evento,
                        principalTable: "Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vendas_Contas_Id_loja",
                        column: x => x.Id_loja,
                        principalTable: "Contas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pagamentos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AtualizadoEm = table.Column<DateTime>(nullable: false),
                    AtualizadoPor = table.Column<string>(nullable: true),
                    Cancelado = table.Column<bool>(nullable: false),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    CriadoPor = table.Column<string>(nullable: true),
                    Deletado = table.Column<bool>(nullable: false),
                    DeletadoEm = table.Column<DateTime>(nullable: false),
                    DeletadoPor = table.Column<string>(nullable: true),
                    Id_venda = table.Column<Guid>(nullable: false),
                    Total = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagamentos_Vendas_Id_venda",
                        column: x => x.Id_venda,
                        principalTable: "Vendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Venda_Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AtualizadoEm = table.Column<DateTime>(nullable: false),
                    AtualizadoPor = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    CriadoPor = table.Column<string>(nullable: true),
                    Deletado = table.Column<bool>(nullable: false),
                    DeletadoEm = table.Column<DateTime>(nullable: false),
                    DeletadoPor = table.Column<string>(nullable: true),
                    Id_produto = table.Column<Guid>(nullable: false),
                    Id_venda = table.Column<Guid>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    ValorTotal = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Venda_Produtos_Produtos_Id_produto",
                        column: x => x.Id_produto,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venda_Produtos_Vendas_Id_venda",
                        column: x => x.Id_venda,
                        principalTable: "Vendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movimentacoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AtualizadoEm = table.Column<DateTime>(nullable: false),
                    AtualizadoPor = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    CriadoPor = table.Column<string>(nullable: true),
                    Deletado = table.Column<bool>(nullable: false),
                    DeletadoEm = table.Column<DateTime>(nullable: false),
                    DeletadoPor = table.Column<string>(nullable: true),
                    Id_Pagamento = table.Column<Guid>(nullable: true),
                    Id_ficha = table.Column<Guid>(nullable: false),
                    MovimentacaoTipo = table.Column<int>(nullable: false),
                    Observacao = table.Column<string>(nullable: true),
                    SaldoAnterior = table.Column<double>(nullable: false),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimentacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movimentacoes_Pagamentos_Id_Pagamento",
                        column: x => x.Id_Pagamento,
                        principalTable: "Pagamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movimentacoes_Fichas_Id_ficha",
                        column: x => x.Id_ficha,
                        principalTable: "Fichas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contas_Id_Conta_Principal",
                table: "Contas",
                column: "Id_Conta_Principal",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conta_Funcionarios_Id_funcionario",
                table: "Conta_Funcionarios",
                column: "Id_funcionario");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_Id_evento",
                table: "Contratos",
                column: "Id_evento");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_Id_loja",
                table: "Contratos",
                column: "Id_loja");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_Id_organizador",
                table: "Contratos",
                column: "Id_organizador");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_Id_organizador",
                table: "Eventos",
                column: "Id_organizador");

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacoes_Id_Pagamento",
                table: "Movimentacoes",
                column: "Id_Pagamento");

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacoes_Id_ficha",
                table: "Movimentacoes",
                column: "Id_ficha");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_Id_venda",
                table: "Pagamentos",
                column: "Id_venda");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_Fichas_Id_ficha",
                table: "Pagamento_Fichas",
                column: "Id_ficha");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_Id_Cor",
                table: "Produtos",
                column: "Id_Cor");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_Id_loja",
                table: "Produtos",
                column: "Id_loja");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_Id_Evento",
                table: "Vendas",
                column: "Id_Evento");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_Id_loja",
                table: "Vendas",
                column: "Id_loja");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_Produtos_Id_produto",
                table: "Venda_Produtos",
                column: "Id_produto");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_Produtos_Id_venda",
                table: "Venda_Produtos",
                column: "Id_venda");

            migrationBuilder.AddForeignKey(
                name: "FK_Conta_Funcionarios_Contas_Id_funcionario",
                table: "Conta_Funcionarios",
                column: "Id_funcionario",
                principalTable: "Contas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Contatos_Id",
                table: "Contas");

            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Enderecos_Id",
                table: "Contas");

            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Conta_Funcionarios_Id_Conta_Principal",
                table: "Contas");

            migrationBuilder.DropTable(
                name: "Contratos");

            migrationBuilder.DropTable(
                name: "Movimentacoes");

            migrationBuilder.DropTable(
                name: "Pagamento_Fichas");

            migrationBuilder.DropTable(
                name: "Venda_Produtos");

            migrationBuilder.DropTable(
                name: "Pagamentos");

            migrationBuilder.DropTable(
                name: "Fichas");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropTable(
                name: "Cores");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Conta_Funcionarios");

            migrationBuilder.DropTable(
                name: "Contas");
        }
    }
}
