using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prova27_10.Pages.Professor;
using Prova27_10.Pages.Recepcao;
using Prova27_10.Pages.Orcamento;
using Prova27_10.Pages.Estoque;

namespace Prova27_10.Data
{
    public class Prova27_10Context : DbContext
    {
        public Prova27_10Context (DbContextOptions<Prova27_10Context> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = ARADSK273\SQLEXPRESS; Initial Catalog=BDEscola; Integrated Security = true");
        }

        public DbSet<Prova27_10.Pages.Professor.Professor> Professor { get; set; }

        public DbSet<Prova27_10.Pages.Recepcao.Funcionario> Recepcao { get; set; }

        public DbSet<Prova27_10.Pages.Orcamento.Orcamento> Orcamento { get; set; }

        public DbSet<Prova27_10.Pages.Estoque.Estoque> Estoque { get; set; }
    }
}
