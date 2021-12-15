using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiteAgencia.Models
{
    public class Cliente
    {
        [Key()]
        public int id_cliente { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public string email { get; set; }
        public string cpf { get; set; }
        [Required]
        public string senha { get; set; }

        public virtual List<Cliente> cliente { get; set; }
    }
}
