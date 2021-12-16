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
        public int Id { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public virtual Cliente cliente {get;set;}

        [ForeignKey("Destinos")]
        public int DestinoId { get; set; }
        public virtual Destinos destino {get;set;}

    }
}
