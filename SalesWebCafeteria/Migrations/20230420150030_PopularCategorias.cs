using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebCafeteria.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome,Descricao) " +
                "VALUES('Paes Doces', 'Pães doces com recheio e sem recheio')");

            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome,Descricao) " +
               "VALUES('Paes Salgados', 'Pães doces com recheio e sem recheio')");

            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome,Descricao) " +
              "VALUES('Bolos', 'Bolos com cobertura e sem cobertura')");

            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome,Descricao) " +
             "VALUES('Cafe Tradicional', 'Tradicional e com Leite')");

            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome,Descricao) " +
             "VALUES('Cafe Especial', 'Mocacciono')");

            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome,Descricao) " +
            "VALUES('Lanches', 'Natural e Chess Salada')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categoria");
        }
    }
}
