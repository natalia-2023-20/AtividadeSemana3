using System.ComponentModel.DataAnnotations;

namespace AvaChocolatier.Models
{
    public class Produto
    {
        [Display(Name = "Nível de acesso")]
        [Required]
        public int NivelID { get; set; }

        public int ProdutoID { get; set; }

        [Display(Name = "Nome do produto")]
        public string? Nome { get; set; }

        [Display(Name = "Preço do produto")]
        public string? Preco { get; set; }

        [Display(Name = "Quantidade no estoque")]
        public int Quantidade { get; set; }
    }
}
