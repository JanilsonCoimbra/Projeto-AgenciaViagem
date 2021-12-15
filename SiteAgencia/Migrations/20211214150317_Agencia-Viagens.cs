using Microsoft.EntityFrameworkCore.Migrations;

namespace SiteAgencia.Migrations
{
    public partial class AgenciaViagens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CadastroCompra",
                columns: table => new
                {
                    id_compra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_cliente = table.Column<int>(type: "int", nullable: false),
                    id_destino = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroCompra", x => x.id_compra);
                });

            migrationBuilder.CreateTable(
                name: "CadastroCliente",
                columns: table => new
                {
                    id_cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clienteid_cliente = table.Column<int>(type: "int", nullable: true),
                    Comprasid_compra = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroCliente", x => x.id_cliente);
                    table.ForeignKey(
                        name: "FK_CadastroCliente_CadastroCliente_Clienteid_cliente",
                        column: x => x.Clienteid_cliente,
                        principalTable: "CadastroCliente",
                        principalColumn: "id_cliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CadastroCliente_CadastroCompra_Comprasid_compra",
                        column: x => x.Comprasid_compra,
                        principalTable: "CadastroCompra",
                        principalColumn: "id_compra",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CadastroDestino",
                columns: table => new
                {
                    id_Destino = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    destino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valor = table.Column<float>(type: "real", nullable: false),
                    Comprasid_compra = table.Column<int>(type: "int", nullable: true),
                    Destinosid_Destino = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroDestino", x => x.id_Destino);
                    table.ForeignKey(
                        name: "FK_CadastroDestino_CadastroCompra_Comprasid_compra",
                        column: x => x.Comprasid_compra,
                        principalTable: "CadastroCompra",
                        principalColumn: "id_compra",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CadastroDestino_CadastroDestino_Destinosid_Destino",
                        column: x => x.Destinosid_Destino,
                        principalTable: "CadastroDestino",
                        principalColumn: "id_Destino",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CadastroCliente_Clienteid_cliente",
                table: "CadastroCliente",
                column: "Clienteid_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_CadastroCliente_Comprasid_compra",
                table: "CadastroCliente",
                column: "Comprasid_compra");

            migrationBuilder.CreateIndex(
                name: "IX_CadastroDestino_Comprasid_compra",
                table: "CadastroDestino",
                column: "Comprasid_compra");

            migrationBuilder.CreateIndex(
                name: "IX_CadastroDestino_Destinosid_Destino",
                table: "CadastroDestino",
                column: "Destinosid_Destino");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadastroCliente");

            migrationBuilder.DropTable(
                name: "CadastroDestino");

            migrationBuilder.DropTable(
                name: "CadastroCompra");
        }
    }
}
