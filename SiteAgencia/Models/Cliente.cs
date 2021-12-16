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
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        public string Cpf { get; set; }
        [Required]
        public string Senha { get; set; }

        public virtual List<Compras> Compras { get; set; }
    }
}
