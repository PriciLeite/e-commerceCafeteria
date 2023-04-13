using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebCafeteria.Migrations
{
    public partial class CarrinhoCompraItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Laches_Categoria_CategoriaId",
                table: "Laches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Laches",
                table: "Laches");

            migrationBuilder.RenameTable(
                name: "Laches",
                newName: "Lanches");

            migrationBuilder.RenameIndex(
                name: "IX_Laches_CategoriaId",
                table: "Lanches",
                newName: "IX_Lanches_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lanches",
                table: "Lanches",
                column: "LancheId");

            migrationBuilder.CreateTable(
                name: "CarrinhoCompraItens",
                columns: table => new
                {
                    CarrinhoCompraItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LancheId = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CarrinhoCompraId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoCompraItens", x => x.CarrinhoCompraItemId);
                    table.ForeignKey(
                        name: "FK_CarrinhoCompraItens_Lanches_LancheId",
                        column: x => x.LancheId,
                        principalTable: "Lanches",
                        principalColumn: "LancheId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoCompraItens_LancheId",
                table: "CarrinhoCompraItens",
                column: "LancheId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lanches_Categoria_CategoriaId",
                table: "Lanches",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lanches_Categoria_CategoriaId",
                table: "Lanches");

            migrationBuilder.DropTable(
                name: "CarrinhoCompraItens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lanches",
                table: "Lanches");

            migrationBuilder.RenameTable(
                name: "Lanches",
                newName: "Laches");

            migrationBuilder.RenameIndex(
                name: "IX_Lanches_CategoriaId",
                table: "Laches",
                newName: "IX_Laches_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Laches",
                table: "Laches",
                column: "LancheId");

            migrationBuilder.AddForeignKey(
                name: "FK_Laches_Categoria_CategoriaId",
                table: "Laches",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
