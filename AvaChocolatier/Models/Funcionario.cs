using System.ComponentModel.DataAnnotations;

namespace AvaChocolatier.Models
{
    public class Funcionario
    {
        [Display(Name = "Nível de acesso")]
        [Required]
        public int NivelID { get; set; } // chave estrangeira que ta puxando chave primeira
        public int FuncionarioID { get; set; }

        [Display(Name = "Nome do funcionário")] //quem cadastra é o adm
        public string? Nome { get; set; }

        [Display(Name = "CPF do funcionário")]
        public int CPF { get; set; }

        [Display(Name = "Data de admissão do funcionário")]
        public DateTime DtCad { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "O e-mail fornecido não é válido.")]
        [Display(Name = "Digite seu e-mail para cadastro")]
        [Required]
        public string? Email { get; set; }

        [StringLength(10, MinimumLength = 6, ErrorMessage = "Máximo de 10, mínimo de 6 caracteres")]
        [Display(Name = "Digite sua senha para cadastro")]
        [Required]
        public string? Senha { get; set; }

    }
}
