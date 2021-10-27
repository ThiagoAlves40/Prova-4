using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prova27_10.Pages.Estoque
{
    public class Estoque
    {
        public int ID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        [DataType(DataType.Date), Display(Name = "Data de Entrada")]
        public string DataEntrada { get; set; }
        [DataType(DataType.Date), Display(Name = "Data de Saída")]
        public string DataSaida { get; set; }

    }
}
