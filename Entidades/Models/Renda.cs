using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades.Models
{
    public class Renda
    {
        [Key]
        public int IdRenda { get; set; }

        public double dblValorRenda { get; set; }
        public string txtTipoRenda { get; set; }
        public DateTime dteDataEntrada { get; set; }
    }
}
