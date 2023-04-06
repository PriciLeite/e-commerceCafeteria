using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebCafeteria.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "Nome do lanche é obrigatório!")]
        [StringLength(80, MinimumLength =10, ErrorMessage ="O {0} deve ser no mínimo {1} e no máximo {2}")]
        [Display(Name ="Nome do Lache")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório!")]
        [MinLength(20, ErrorMessage ="Mínimo de {1} caractere.")]
        [MaxLength(200, ErrorMessage = "Máximo de {1} caracteres.")]
        [Display(Name = "Descrição")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório!")]
        [MinLength(20, ErrorMessage = "Mínimo de {1} caractere.")]
        [MaxLength(200, ErrorMessage = "Máximo de {1} caracteres.")]
        [Display(Name = "Descrição Detalhada")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Preço é obrigatório!")]
        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage ="Preço entre R$1 e R$999.99")]
        public decimal Preco { get; set; }

        [NotMapped]
        public DateTime DataCriacao { get; set; }

        [Required(ErrorMessage = "Caminho da Imagem Grande!")]
        [StringLength(200, ErrorMessage ="O {0} deve ter no máximo {1} caractere!")]
        public string ImagemUrl { get; set; }

        [Required(ErrorMessage = "Caminho da Imagem Miniatura!")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caractere!")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name ="Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        
        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }

    }
}
