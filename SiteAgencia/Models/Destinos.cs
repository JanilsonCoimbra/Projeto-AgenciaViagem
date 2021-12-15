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
        public int id_Destino { get; set; }
        public string destino { get; set; }
        public string descricao { get; set; }
        public float valor { get; set; }
        public virtual List<Destinos> destinos { get; set; }
    }
}
