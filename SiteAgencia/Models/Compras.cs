using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiteAgencia.Models
{
    public class Compras
    {
        [Key()]
        public int id_compra { get; set; }

        [ForeignKey("Cliente")]
        public int id_cliente { get; set; }
        public virtual List<Cliente> cliente {get;set;}

        [ForeignKey("Destinos")]
        public int id_destino { get; set; }
        public virtual List<Destinos> destino {get;set;}

    }
}
