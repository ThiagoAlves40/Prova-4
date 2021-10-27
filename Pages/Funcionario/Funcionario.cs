using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prova27_10.Pages.Recepcao
{
    public class Funcionario
    {
        public int ID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        public string CPF { get; set; }

        [Required]
        [MinLength(12)]
        [MaxLength(12)]
        public string CTPS { get; set; }

        [Required]
        [DataType(DataType.Date), Display(Name = "Data de Nascimento")]
        public DateTime dtNascimento { get; set; }

        [Required]
        [MinLength(3)]
        public string Endereço { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required]
        public string Setor { get; set; }

    }
}
