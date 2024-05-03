﻿using System.ComponentModel.DataAnnotations;

namespace AvaChocolatier.Models
{
    public class Vendas
    {
        [Display(Name = "Nível de acesso")]
        [Required]
        public int NivelID { get; set; }

        [Key]
        public int VendasID { get; set; }

        [Display(Name = "ID funcionário da venda")]
        public string? func { get; set; }

        [Display(Name = "Nome do produto")]
        public string? Nome { get; set; }

        [Display(Name = "Preço do produto")]
        public string? Preco { get; set; }

        [Display(Name = "Data da venda")]
        public DateTime DtCad { get; set; }
    }
}
