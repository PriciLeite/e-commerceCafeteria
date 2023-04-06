using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebCafeteria.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [StringLength(100,ErrorMessage ="Tamanho máximo de 100 caracteres!")]
        [Required(ErrorMessage ="Nome da Categoria é obrigatório!")]
        [Display(Name ="Nome Categoria")]
        public string CategoriaNome { get; set; }

        [StringLength(100, ErrorMessage = "Tamanho máximo de 100 caracteres!")]
        [Required(ErrorMessage = "Nome da Categoria é obrigatório!")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        
        public List<Lanche> Lanches { get; set; }
    }
}
