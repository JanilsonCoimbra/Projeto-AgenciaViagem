using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiteAgencia.Models
{
    public class Contato
    {
        [Key()]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Mesagem { get; set; }
    }
}
