using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prova27_10.Pages.Orcamento
{
    public class Orcamento
    {
        public int ID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        [Display(Name = "Valor Inicial")]  
        public string ValorInicial { get; set; }
        [Required]
        public string Entradas { get; set; }
        [Required]
        public string Saidas { get; set; }
        [DataType(DataType.Date), Display(Name = "Data do Orçamento")]
        [Required]
        public string MesRef { get; set; }



    }
}
