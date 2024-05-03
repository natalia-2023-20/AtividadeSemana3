using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AvaChocolatier.Models;

namespace AvaChocolatier.Data
{
    public class AvaChocolatierContext : DbContext
    {
        public AvaChocolatierContext (DbContextOptions<AvaChocolatierContext> options)
            : base(options)
        {
        }

        public DbSet<AvaChocolatier.Models.NivelAcesso> NivelAcesso { get; set; } = default!;
        public DbSet<AvaChocolatier.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<AvaChocolatier.Models.Funcionario> Funcionario { get; set; } = default!;
        public DbSet<AvaChocolatier.Models.Produto> Produto { get; set; } = default!;
        public DbSet<AvaChocolatier.Models.Vendas> Vendas { get; set; } = default!;
    }
}
