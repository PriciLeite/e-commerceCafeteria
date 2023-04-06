using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebCafeteria.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome,Descricao) " +
                "VALUES('Pães Doces', 'Pães doces com recheio e sem recheio')");

            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome,Descricao) " +
               "VALUES('Pães Salgados', 'Pães doces com recheio e sem recheio')");

            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome,Descricao) " +
              "VALUES('Bolos', 'Bolos com cobertura e sem cobertura')");

            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome,Descricao) " +
             "VALUES('Café', 'Tradicional e com Leite')");

            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome,Descricao) " +
             "VALUES('Café', 'Mocacciono')");

            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome,Descricao) " +
            "VALUES('Lanches', 'Natural e Misto Quente')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categoria");
        }
    }
}
