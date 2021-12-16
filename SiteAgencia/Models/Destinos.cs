using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiteAgencia.Models
{
    public class Destinos
    {
        [Key()]
        public int Id { get; set; }
        public string Destino { get; set; }
        public string Descricao { get; set; }
        public string   Valor { get; set; }
        public virtual List<Compras> compras { get; set; }
    }
}
