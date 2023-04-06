using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebCafeteria.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque,CategoriaId) VALUES('Pão Francês', 'Água, Sal, Farinha de trigo, Fermento biológico', 'Delicioso pão francês, crocante e quentinho. Preço em Kg',12.99, 'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg','http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg',1,200,2)");           
            migrationBuilder.Sql("INSERT INTO Lanches(Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque,CategoriaId) VALUES('Pão de Creme','Pão doce, creme confeteiro, Base de leite e Farinha de trigo.', 'Delicioso pão doce com creme confeiteiro. Preço por UNI',1.50,'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg','http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg',0,200,1)");
            migrationBuilder.Sql("INSERT INTO Lanches(Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque,CategoriaId) VALUES('Bolo Chocolate','Farinha de trigo, ovos, leite, manteiga, chocolate em pó.','Delicioso bolo de chocolate com cobertura de chocolate. Preço por UNI.',20.00,'http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg','http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg',0,10,3)");
            migrationBuilder.Sql("INSERT INTO Lanches(Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque,CategoriaId) VALUES('Café Tradicional','Café em grãos.','Delicioso café em grãos moido na hora. Preço por UNI',5.00,'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg','http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg',1,200,4)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
