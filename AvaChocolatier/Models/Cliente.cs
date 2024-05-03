using System.ComponentModel.DataAnnotations;

namespace AvaChocolatier.Models
{
    public class Cliente
    {
        [Display(Name = "Nível de acesso")]
        [Required]
        public int NivelID { get; set; }
        public int ClienteId { get; set; }

        [Display(Name = "Nome do cliente")]
        public string? Name { get; set; }

        [Display(Name = "CPF cliente")]
        public string? CPF { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "O e-mail fornecido não é válido.")]
        [Display(Name = "Digite seu E-mail para cadastro")]
        [Required]
        public string? Usuario { get; set; }

        [StringLength(10, MinimumLength = 6, ErrorMessage = "Máximo de 10, mínimo de 6 caracteres")]
        [Display(Name = "Digite sua senha para cadastro")]
        [Required]
        public string? Senha { get; set; }
    }
}
