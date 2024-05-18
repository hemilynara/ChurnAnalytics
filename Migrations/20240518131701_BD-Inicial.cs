using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChurnAnalitycs.Migrations
{
    /// <inheritdoc />
    public partial class BDInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CadastroEmpresas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    RazaoSocial = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    CNPJ = table.Column<string>(type: "NVARCHAR2(14)", maxLength: 14, nullable: false),
                    SetorAtuacao = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Porte = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Endereco = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Numero = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Bairro = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Cidade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Estado = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CEP = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Pais = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NomeContatoPrincipal = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    CargoContatoPrincipal = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    EmailContato = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    TelefoneContato = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ProdutoServicoAdquirido = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ValorCompra = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ReceitaAnual = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Lucratividade = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroEmpresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DataFeedback = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    IndicadorDesempenho = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    ValorIndicador = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TipoInteracao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NomeCanalComunicacao = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    DataAtendimento = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    TipoAtendimento = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    ResolucaoProblema = table.Column<string>(type: "NVARCHAR2(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InfoAdicionais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NomeIntegracaoSistema = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    InfoProdutosServicos = table.Column<string>(type: "NVARCHAR2(1000)", maxLength: 1000, nullable: false),
                    OutrasInformacoesSetor = table.Column<string>(type: "NVARCHAR2(1000)", maxLength: 1000, nullable: false),
                    SegmentacaoClientes = table.Column<string>(type: "NVARCHAR2(500)", maxLength: 500, nullable: false),
                    PersonaCliente = table.Column<string>(type: "NVARCHAR2(500)", maxLength: 500, nullable: false),
                    EstruturaOrganizacional = table.Column<string>(type: "NVARCHAR2(500)", maxLength: 500, nullable: false),
                    InformacoesRegulatoriasConformidade = table.Column<string>(type: "NVARCHAR2(500)", maxLength: 500, nullable: false),
                    ObjetivosMetasEstrategicas = table.Column<string>(type: "NVARCHAR2(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoAdicionais", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadastroEmpresas");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "InfoAdicionais");
        }
    }
}
